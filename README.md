# MaruchuTextureChecker

㊥Maruchuテクスチャチェッカー<br>

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Sample1.png" alt="使用サンプル">

Copyright(C) 2020 [㊥Maruchu](https://twitter.com/Maruchu "㊥Maruchu")


<br><br>

## 概要

3Dモデルを使った作業中に、現在 使用しているテクスチャの一覧が見られると便利ですよね。<br>

というわけで貼り付けると配下のオブジェクトが持っているテクスチャを<br>
探してきて表示してくれるUnity用スクリプトです。


<br><br><br><br>

## 使い方

Unity でプロジェクトを開いたら、Projectタブから Assets/Sample1 というシーンを開いてみてください。<br>
Hierarchyタブに unitychan というオブジェクトがあるのを確認してクリックします。

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Editor1.png" alt="使い方1">


unitychan オブジェクトをクリックしたら、Inspectorタブで AddComponent ボタンを押し、<br>
「Maruchu」と入力 → MaruchuTextureChecker をクリックするとスクリプトをオブジェクトに追加できます。

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Editor2.png" alt="使い方2">


スクリプトが追加されると、結果が Console と Inspector に表示されているので確認してみてください。

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Editor3.gif" alt="使い方3">




<br><br><br><br>

## Consoleの見方

Consoleタブから「MARUCHU TEXTURE CHECKER」と書かれたログをクリックしてください。<br>
その下に詳細が表示されます

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Console1.png" alt="Consoleの見方">

1.　取得できたテクスチャの合計メモリです<br>
　ビルドターゲットに関係なく(iOSやAndroidの設定に関係なく)、<br>
　エディタでの使用メモリが表示されることに注意してください<br>

2.　取得できたテクスチャのサイズ別の枚数です<br>

3.　取得できたテクスチャの一覧です<br>

4.　ここから先は見なくてOKです
　(Unityが自動的に出力してくれるログです)


<br><br><br><br>

## Inspectorの値

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Inspector1.png" alt="Inspectorの値">

1.「配下のテクスチャをチェック」ボタン<br>
　任意のタイミングでチェックを行いたいときは このボタンを押してください<br>
　(スクリプトを AddComponent したときの処理が もう一度 行われます)

2.　CheckPropNameArray (※上級者向け)<br>
　テクスチャを取得するための、シェーダーのプロパティ名を指定できます<br>
　よくわからない場合は触らないでおいてください

3.　ResultMemory<br>
　取得できた全テクスチャの使用メモリが表示されます<br>
　ビルドターゲットに関係なく(iOSやAndroidの設定に関係なく)、<br>
　エディタでの使用メモリが表示されることに注意してください<br>

4.　ResultSize<br>
　取得できたテクスチャのピクセルサイズ別の枚数が表示されます<br>

5.　ResultName<br>
　取得できた全テクスチャの名前が表示されます
 

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Inspector2.png" alt="Inspectorの値">

6.　ResultMatList<br>
　配下で取得できた全マテリアルが表示されます<br>
7.　ResultTexList<br>
　配下で取得できた全テクスチャが表示されます


<br><br><br><br>

## ライセンス
㊥MaruchuテクスチャチェッカーにはMITライセンスが適用されています<br>

サンプルとして同梱されているユニティちゃんの各種アセットには<br>
ユニティちゃんライセンスが適用されています<br>
© Unity Technologies Japan/UCL

