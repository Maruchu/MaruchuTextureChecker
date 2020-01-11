﻿# MaruchuTextureChecker
㊥Maruchuテクスチャチェッカー<br>

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Sample1.png" alt="使用サンプル">

Copyright(C) 2020 [㊥Maruchu](https://twitter.com/Maruchu "㊥Maruchu")


<br><br><br><br>

## 概要

3Dモデルを使った作業中に、現在 使用しているテクスチャの一覧が見られると便利ですよね。<br>
というわけで貼り付けると配下のオブジェクトが持っているテクスチャを探してきて表示してくれるスクリプトです。<br>


<br><br><br><br>

## 使い方

Projectタブから Assets/Sample1 というシーンを開いてみてください。<br>
Hierarchyタブに unitychan というオブジェクトがあるのを確認してクリックします。

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Editor1.png" alt="使い方1">


unitychan オブジェクトをクリックしたら、Inspectorタブで AddComponent ボタンを押し、<br>
「Maruchu」と入力 → MaruchuTextureChecker をクリックするとスクリプトをオブジェクトに追加できます。

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Editor2.png" alt="使い方2">


スクリプトが追加されると、結果が Console と Inspector に表示されているので確認してみてください。

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Editor3.gif" alt="使い方3">


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
　取得した全テクスチャの使用メモリが表示されます<br>
　ビルドターゲットに関係なく(iOSやAndroid版ではなく)、<br>
　エディタでの使用メモリが表示されることに注意してください<br>

4.　ResultSize<br>
　取得したテクスチャのピクセルサイズ別の枚数が表示されます<br>

5.　ResultName<br>
　取得した全テクスチャの名前が表示されます
 

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/b/Inspector2.png" alt="Inspectorの値">

6.　ResultMatList<br>
　配下で取得した全マテリアルが表示されます<br>
7.　ResultTexList<br>
　配下で取得した全テクスチャが表示されます


<br><br><br><br>

## ライセンス
㊥MaruchuテクスチャチェッカーにはMITライセンスが適用されています<br>

サンプルとして同梱されているユニティちゃんの各種アセットには<br>
ユニティちゃんライセンスが適用されています<br>
© Unity Technologies Japan/UCL

