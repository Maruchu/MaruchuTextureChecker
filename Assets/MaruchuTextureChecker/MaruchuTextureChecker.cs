/*
 * MaruchuTextureChecker
 * 
 * Copyright(C) 2020 ㊥Maruchu
 * 
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */




#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.Profiling;
using System.Collections.Generic;
using UnityEditor;



/// <summary>
/// 配下のオブジェクトが持っているテクスチャの一覧と容量を表示してくれるスクリプト
/// </summary>
public class MaruchuTextureChecker : MonoBehaviour
{
    //チェックするテクスチャのパラメータ
    [SerializeField]
    private string[] checkPropNameArray = new string[]
    {
        //基本的にはこれだけあればOK
        "_MainTex",
        //↓のものはお好みで追加・削除してください

        //代表的なもの
        "_SubTex",
        "_BumpMap",
        "_NormalMap",

        //ユニティちゃんが持ってるパラメータ
        "_FalloffSampler",
        "_RimLightSampler",
        "_SpecularReflectionSampler",
        "_EnvMapSampler",
        "_NormalMapSampler",
        "_AlphaMask",
    };

    //初期化フラグ
    [HideInInspector]
    public bool initializedFlag = false;

    //結果表示　使用メモリ用
    [SerializeField, Multiline(2)]
    private string resultMemory = string.Empty;
    //結果表示　サイズ(ピクセル数)別の枚数表示用
    [SerializeField, Multiline(8)]
    private string resultSize = string.Empty;
    //結果表示　詳細表示用
    [SerializeField, Multiline(10)]
    private string resultName = string.Empty;

    //マテリアル一覧表示用
    [SerializeField]
    private List<Material> resultMatList = new List<Material>();
    //テクスチャ一覧表示用
    [SerializeField]
    private List<Texture> resultTexList = new List<Texture>();

    //サイズの記憶用
    private Dictionary<Vector2Int, int> texSizeDict = new Dictionary<Vector2Int, int>();



    /// <summary>
    /// 初期化
    /// </summary>
    private void Awake()
    {
        //実行してたら起動時に一回書き出し
        Check();
    }
    /// <summary>
    /// テクスチャのチェックと書き出し実行
    /// </summary>
    public void Check()
    {
        //初期化
        resultMatList.Clear();
        resultTexList.Clear();
        texSizeDict.Clear();

        //容量チェック
        Renderer[] array = gameObject.GetComponentsInChildren<Renderer>();
        Vector2Int texSize;
        foreach (Renderer rend in array)
        {
            //Material確認
            foreach (Material mat in rend.sharedMaterials)
            {
                //Texture確認
                foreach (string propName in checkPropNameArray)
                {
                    //プロパティの存在を確認
                    if (!mat.HasProperty(propName))
                    {
                        continue;
                    }
                    //プロパティ名を確認
                    Texture tempTex = mat.GetTexture(propName);
                    if (null == tempTex)
                    {
                        continue;
                    }

                    //新しいテクスチャ？
                    if (!resultTexList.Contains(tempTex))
                    {
                        //テクスチャを記憶
                        resultTexList.Add(tempTex);

                        //Dictionaryでサイズ別に枚数を記憶
                        texSize = GetTexSize(tempTex);
                        if (texSizeDict.ContainsKey(texSize))
                        {
                            //枚数を+1
                            texSizeDict[texSize]++;
                        }
                        else
                        {
                            //1枚め
                            texSizeDict.Add(texSize, 1);
                        }
                    }
                }

                //新しいMaterial？
                if (!resultMatList.Contains(mat))
                {
                    //Materialを記憶
                    resultMatList.Add(mat);
                }
            }
        }

        //出力
        {
            //結果表示用の文字列を作る
            string sizeResult = name + " 以下のテクスチャサイズ別 枚数\n\n";
            foreach (var key in texSizeDict.Keys)
            {
                //枚数一覧
                sizeResult += key + "px = " + texSizeDict[key] + "枚\n";
            }
            string nameResult = name + " 以下の取得可能なテクスチャ一覧\n\n";
            long allMem = 0;
            foreach (var temp in resultTexList)
            {
                //容量取得
                long useMem = Profiler.GetRuntimeMemorySizeLong(temp);
                allMem += useMem;
                //サイズ表示
                texSize = GetTexSize(temp);
                nameResult += temp.name + "\t\t(" + texSize.x + "x" + texSize.y + "px, " + (useMem / 1024f / 1024f).ToString("0.00") + "MB)\n";
            }

            //Inspector表示用
            resultMemory = (allMem / 1024f / 1024f).ToString("0.00") + " MByte\n(" + allMem + " Byte)";
            resultSize = sizeResult;
            resultName = nameResult;
            //デバッグ出力
            Debug.LogWarning("---- MARUCHU TEXTURE CHECKER ----\nMemSize = " + (allMem / 1024f / 1024f).ToString("0.00") + "MB\n\n--------\n" + sizeResult + "\n--------\n" + nameResult + "\n--------\n");
        }
    }
    /// <summary>
    /// テクスチャのチェックと書き出し実行
    /// </summary>
    private Vector2Int GetTexSize(Texture tempTex)
    {
        return new Vector2Int((int)(1.0f / tempTex.texelSize.x), (int)(1.0f / tempTex.texelSize.y));
    }
}

/// <summary>
/// Inspector表示用
/// </summary>
[CustomEditor(typeof(MaruchuTextureChecker))]
public class MaruchuTextureCheckerEditor : Editor
{
    /// <summary>
    /// Inspector表示用
    /// </summary>
    public override void OnInspectorGUI()
    {
        //再チェック用にボタンを付ける
        {
            //元のスクリプトを取得
            MaruchuTextureChecker targetScript = target as MaruchuTextureChecker;
            //チェックする？                                       あるいは最初の一回
            if (GUILayout.Button("配下のテクスチャをチェック") || !targetScript.initializedFlag)
            {
                //ボタンが押された
                targetScript.Check();
                //チェック済み
                targetScript.initializedFlag = true;
            }
        }

        //親のGUI表示をそのままやる
        base.OnInspectorGUI();
    }
}
#endif
