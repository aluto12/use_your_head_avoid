# use_your_head_avoid
UnityとPythonを使った、ユーザの頭を傾けて操作するゲーム

ブロックを自分の頭を傾けることで操作するゲーム.ゲームはUnityで実装されている。Pythonでがカメラの画像処理によりカメラに映った人の顔の向きを検出し、UDP通信を用いてUnityに送信する.
このゲームを動作させる前にPythonのプログラムを動作させる必要がある.また、プログラムを動作するにはカメラへの接続が必要になる.

Pythonの実行方法及び環境構築方法は以下の通りである.(anacondaで仮想環境を作り動作確認を行った)

環境構築するためのコマンド(requirements.txt内のライブラリとtorch,torchvisionライブラリを入れる)
python3 -m venv venv
pip install -r requirements.txt 
pip3 install torch torchvision torchaudio --extra-index-url https://download.pytorch.org/whl/cu117

実行コマンド
python demo.py  --snapshot output-model.pth --cam 0

