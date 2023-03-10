# Use_Your_Head_Avoid
「Use_Your_Head_Avoid」は、UnityとPythonを使った、ユーザの頭を傾けて操作するゲームです。

<iframe width="560" height="315" src="https://www.youtube.com/embed/Fzx3UztZvfc" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>

このゲームでは、ブロックを自分の頭を傾けることで操作します。ゲームはUnityで実装されており、Pythonでカメラの画像処理により、カメラに映った人の顔の向きを検出し、UDP通信を用いてUnityに送信します。このゲームを動作させる前には、Pythonのプログラム(head_pose_estimationフォルダ参照)を動作させる必要があります。また、プログラムを動作させるには、カメラへの接続が必要です。
Pythonの実行方法及び環境構築方法は以下の通りである.(anacondaで仮想環境を作り動作確認を行った)

## 環境構築
環境構築するためのコマンド(requirements.txt内のライブラリとtorch,torchvisionライブラリを入れる)
```
python3 -m venv venv
pip install -r requirements.txt 
pip3 install torch torchvision torchaudio --extra-index-url https://download.pytorch.org/whl/cu117
```
## 実行コマンド
```
python demo.py  --snapshot output-model.pth --cam 0
```
