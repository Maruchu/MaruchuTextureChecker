# MaruchuTextureChecker
㊥Maruchuテクスチャチェッカー<br>

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/a/Sample1.png" alt="使用サンプル">

Copyright(C) 2020 [㊥Maruchu](https://twitter.com/Maruchu "㊥Maruchu")


<br><br><br><br>

## 概要

キャラや背景の3Dモデルを使った作業中に、現在 使用しているテクスチャの一覧が見られると便利ですよね。<br>
というわけで貼り付けると配下のオブジェクトが持っているテクスチャを探してきて表示してくれるスクリプトです。<br>

プロジェクトに MaruchuTextureChecker というスクリプトが入っているので、<br>
Renderer を持っている適当なオブジェクトの Inspector から AddComponent してみてください。<br>
(適当な3Dモデルデータが無い場合、AssetStore でユニティちゃんモデルなどをDLしてお使いください)


<br><br><br><br>

## 使い方

スクリプトを AddComponent すると、結果が Console と Inspector に表示されます

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/a/Sample2.gif" alt="使い方">


<br><br><br><br>

## Inspectorの値

・「配下のテクスチャをチェック」ボタン<br>
　スクリプトを AddComponent したときに自動的に一度チェックが行われますが、<br>
　任意のタイミングで行いたいときは このボタンを押してください

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/a/Inspector1.png" alt="Inspectorの値">

・CheckPropNameArray (※上級者向け)<br>
　テクスチャを取得するための、シェーダーのプロパティ名を指定できます<br>
　よくわからない場合は触らないでおいてください

・ResultMemory<br>
　全テクスチャの使用メモリが表示されます<br>
　ビルドターゲットに関係なく(iOSやAndroid版ではなく)、<br>
　エディタでの使用メモリが表示されることに注意してください

・ResultSize<br>
　テクスチャのピクセルサイズ別の枚数が表示されます<br>

・ResultName<br>
　全テクスチャの名前一覧が表示されます
 

<img src="http://many.chu.jp/Unity/MaruchuTextureChecker/a/Inspector2.png" alt="Inspectorの値">

・ResultMatList<br>
　配下の全マテリアルが表示されます<br>
・ResultTexList<br>
　配下の全テクスチャが表示されます


<br><br><br><br>

## ライセンス
㊥MaruchuテクスチャチェッカーにはMITライセンスが適用されています<br>
