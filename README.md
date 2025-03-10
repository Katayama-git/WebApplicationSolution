# 2025年新入社員研修開発環境構築

## Visual Studio2022のインストール手順
1.[ここをクリック](https://visualstudio.microsoft.com/ja/vs/community/)してサイトにアクセスし、Visual Studio Community 2022の無償ダウンロードボタンが下のほうにあると思いますのでそこをクリックしてインストーラーをダウンロードして下さい。ダウンロード出来たらダウンロードしたインストーラーを実行してインストールして下さい。<br>
2.インストール中にワークロードの項目があると思いますので以下のように選択して下さい。(インストール後にも変更可能です。)<br>
　・Web&クラウド："ASP.NETとWeb開発"にチェックを入れる。<br>
　・デスクトップとモバイル：".NETデスクトップ開発"にチェックを入れる。<br>
　・他のツールセット："データの保存と処理"にチェックを入れる。<br>

※[VSC2022インストール手順参考サイト](https://qiita.com/mmake/items/e0abb649683b96e2226a)<br>

## Githubのリポジトリをフォーク及びクローンする手順
1.Githubのアカウントをお持ちでない場合は[ここをクリック](https://github.com)して公式サイトでアカウントを作成して下さい。(作成したアカウント名やパスワード、登録した際のメールアドレスは忘れないよう保管しておいて下さい。)<br>
2.Githubのアカウントが作成出来たらそのアカウントでサインインして下さい。サインインした状態で他人のリポジトリをフォークしてもらいます。リポジトリとはワークスペースのようなものでフォルダやファイルがまとまったものあるいはそれがあるスペースを指し、フォークとは他人のリポジトリをコピーしてくることです。<br>
具体的な方法は、まず[このリポジトリ](https://github.com/Katayama-git/WebApplicationSolution)をブラウザでアクセスして下さい。そして表示された画面に画像のような箇所があると思います。そのForkをクリックするとフォーク作成画面に移ります。そこで次の画像のようなチェック項目を**必ずオフにして下さい**。これがチェックされたままCreate forkするとリポジトリの一部分しかフォーク出来ません。チェックを外したらCreate forkをクリックしてフォークして下さい。<br>
3.次にフォークしてきたリポジトリをPC内のローカルにクローンします。クローンもコピーのようなものなのですが、これはGithub上にあるつまりネットワーク上にあるリポジトリ(リモートリポジトリ)にリンクしたリポジトリをローカル(自PC内)に作成しています。ネットワーク上にあるリモートリポジトリに対比してこちらはローカルリポジトリと言います。<br>
クローンの具体的な方法はVisual Studioを起動し、Visual Studioのスタートウィンドウで"リポジトリのクローン"をクリックします。もし起動時に画像のようなスタートウィンドウが無ければ、画面上部にある"ファイル"をクリックし表示されたコンテキストからスタートウィンドウをクリックすればスタートウィンドウが表示されます。<br>
そして"リポジトリのクローン"をクリックして表示された画面で次の画像での"リポジトリを参照する"のGithubをクリックし、先ほど作成した自身のGithubのアカウントを参照しましょう。おそらくフォークしたリポジトリが画像のようにあるはずです。あとはそれを選択した状態で"クローン"をクリックすればPC内にクローンされます。(Local pathにクローンしたリポジトリをどこに置くかが設定されているので、どこにクローンしたかパスをコピーして保管することをお勧めします。)<br>
4.しかし、クローン後に自動で開かれたのはリポジトリ自体であり、今回Visual Studioで開くのはそのリポジトリ内のWebApplicationSolution.slnというファイルです。なので再びスタートウィンドウっを開き、今度は"プロジェクトやソリューションを開く"をクリックし、表示されたエクスプローラーでクローンしたリポジトリ内のWebApplicationSolution.slnファイルを開いて下さい。

## SQL Server2022とSQL Server Management Studio(SSMS)のインストール手順
1．[ここをクリック](https://qiita.com/portfoliokns3/items/9e3d1196d680a39dd223)してサイトにアクセスし、サイトを参考にして進めて下さい。

## SSMSから自PC内のSQL Serverに接続する手順(以下英語ver)
1．SSMSを起動すると画像にような画面が表示されると思います。そして画面左側のオブジェクトエクスプローラーのコンセントのようなアイコンをクリックして接続モーダルを表示させます。
![SSMS](https://private-user-images.githubusercontent.com/138543335/418838033-b3c6b965-2ecc-4d5e-876b-297bf340420e.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEwNjM3MDYsIm5iZiI6MTc0MTA2MzQwNiwicGF0aCI6Ii8xMzg1NDMzMzUvNDE4ODM4MDMzLWIzYzZiOTY1LTJlY2MtNGQ1ZS04NzZiLTI5N2JmMzQwNDIwZS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA0JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwNFQwNDQzMjZaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1jNjU4YzM0Njk5ODQ1ZmFmNGY1MzlkNjM3YzFiNjVlN2Y4YjE2YmM0NDI1YTA5YWE2MTZmZTQwM2VjMjE2ODk2JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.GDBKer3plS3mzWhMc6JGjdabs8iKByRyae3jJBygBC0)
2.画像のような接続モーダルが表示されれば、必要な情報を入力していきます。まず、Server nameに接続したいサーバーを入力するのですが、入力欄の右側の下向き矢印をクリックして下さい。<br>すると接続先のサーバー候補がいくつか表示されると思います。その中の"Browse for more..."をクリックすると小さいモーダルが表示されると思います。<br>
 ![SSMS2](https://private-user-images.githubusercontent.com/138543335/418840131-59c4036e-14cf-4d0b-b95b-5e45dc9ccfa8.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEwNjQyMjksIm5iZiI6MTc0MTA2MzkyOSwicGF0aCI6Ii8xMzg1NDMzMzUvNDE4ODQwMTMxLTU5YzQwMzZlLTE0Y2YtNGQwYi1iOTViLTVlNDVkYzljY2ZhOC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA0JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwNFQwNDUyMDlaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT0zY2VlZWFjMDk1YjI0YTQ5OWViYmNlODZkNmNjODIwNDBjMTJmNzUyZjJlMGQ4YjZkNDE5YTUyM2QwMjhjM2UxJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.CKQn6-ZxXcw68y_xayyd0xRi7rAP1xV-I5T7firzWTo)<br>
3.次にプラスのアイコンをクリックするとDatabase Engine配下に自PC名が表示されると思いますのでそれを選択した状態でOKをクリックして下さい。<br>
![SSMS3](https://private-user-images.githubusercontent.com/138543335/418840872-bed3023f-7bf7-4fbd-8918-4dce56e4015b.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEwNjQ0MjMsIm5iZiI6MTc0MTA2NDEyMywicGF0aCI6Ii8xMzg1NDMzMzUvNDE4ODQwODcyLWJlZDMwMjNmLTdiZjctNGZiZC04OTE4LTRkY2U1NmU0MDE1Yi5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA0JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwNFQwNDU1MjNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT0wZWQzNjUyYmY3YzE3OWRlNzEwNzUwY2I4NjgwODFmYmQ1N2E0YTc3NjU5NWU2ZDQ5MjM5OWY3M2EyMzhlNzlhJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.RIxjD19Tr-edlmizCqtt3NxWqQzq7x5vHa1OwyoNRlk)<br>
4.先のモーダルに戻り、Server nameには自PCの名前が入っていると思いますので最後にTrust server certificateにチェックを入れてConnectをクリックして下さい。<br>するとオブジェクトエクスプローラーに接続したサーバーが追加されています。<br>(一度接続したサーバーはServer nameで選択し、Connectをクリックするだけで接続されます。)<br>

## サーバーに新しいログインユーザーとデータベースを作成する手順
1.SSMSを起動し、オブジェクトエクスプローラーに先程追加したサーバーがある状態からスタートします。<br>
2.まず、新しいログインユーザーを作成します。プラスのアイコンをクリックして画像にように開いていくと、サーバー名(自PC名)/Security/Logins配下に既にデフォルトでいくつかログインユーザーが登録されていると思います。<br>
![SSMS4](https://private-user-images.githubusercontent.com/138543335/418841450-2e0423b5-5097-44f6-8287-12819408c241.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEwNjQ1NzEsIm5iZiI6MTc0MTA2NDI3MSwicGF0aCI6Ii8xMzg1NDMzMzUvNDE4ODQxNDUwLTJlMDQyM2I1LTUwOTctNDRmNi04Mjg3LTEyODE5NDA4YzI0MS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA0JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwNFQwNDU3NTFaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1iYjRiYjE1Njc5ZmZhOGI3MWM2MzBmYTI1NmM0M2M2YTUwYzc1YjBjNjE5YjZiYzhhM2Y4ZWZmMzJmOWVlN2E3JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.m3EqnDtpw_V2M1TC7S6BujuKv8I6vMMP7col7XihDNk)<br>
3.ここに新しくログインユーザーを登録するには、まずLoginsフォルダを右クリックして、次にNew Login...をクリックするとモーダルが表示されます。このモーダルにログインユーザーの情報を入力していきますので、入力した情報はどこかにメモする等して保管してください。<br>

4.入力する箇所は画像のようにまずLogin nameに任意のログインユーザー名を入力し、SQL Server authenticationにチェックを入れて任意のパスワードを入力してください。入力出来たらOKをクリックして下さい。<br>Logins配下に新しく登録したログインユーザーが追加されていると思います。<br>
![SSMS5](https://private-user-images.githubusercontent.com/138543335/418842011-34aa89df-ca77-4cda-b9f9-b1e530c596b8.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEwNjQ3MTUsIm5iZiI6MTc0MTA2NDQxNSwicGF0aCI6Ii8xMzg1NDMzMzUvNDE4ODQyMDExLTM0YWE4OWRmLWNhNzctNGNkYS1iOWY5LWIxZTUzMGM1OTZiOC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA0JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwNFQwNTAwMTVaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1lZDVjMTdkZTkzNWU3YTYzOWZiOWZkZjNmNDUzMDhjMjI1MGFjNmEwNTVjY2Y4NmE1YWRkODFiMGM3YzA3MGM0JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.XSaL-ovUT7LGbedmd5ENYdk1yeNDZhrnkx4EEWX5ORg)<br>
5.次にサーバーに新しいデータベースを作成します。サーバー名(自PC名)/Databasesフォルダを右クリックして、New Database...をクリックするとモーダルが表示されます。<br>そのモーダルのDatabase nameにUserと入力してOKをクリックするとDatabases配下にUserというデータベースが作成されます。<br>

## データベースに新しいテーブルを追加する手順
1.作成したデータベースをプラスのアイコンをクリックして開くと、画像のような構造になってるのでその中のTablesを右クリックしてNew →　Table...の順にクリックして下さい。<br>すると右側にテーブルの構造を設定するタブが表示されると思います。<br>
![SSMS6](https://private-user-images.githubusercontent.com/138543335/418842669-187dae95-b75b-460b-8cac-9908b005f23e.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEwNjQ4NTcsIm5iZiI6MTc0MTA2NDU1NywicGF0aCI6Ii8xMzg1NDMzMzUvNDE4ODQyNjY5LTE4N2RhZTk1LWI3NWItNDYwYi04Y2FjLTk5MDhiMDA1ZjIzZS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA0JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwNFQwNTAyMzdaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1mOTg3ZTYxNTdiNGU0ZjI2ZDViMWM4MTdlYTA1ODVhZjAzOWU5NmNjMjgwYmM4MTNhODgzMmE1M2ZkOWI1ZTE0JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.snCgq3QcCnrkVatyZbVraCI_j2R0Yz4nsBeThNRYIgY)<br>
2.そのタブで画像のようにまずColumn NameがIdでData Typeがintのカラムを入力し、次にColumn NameがNameでData Typeが"nvarchar(50)"のカラムを入力して下さい。<br>また、Idのカラムはプライマリキーなので右クリックして、Set Primary Keyをクリックしてプライマリキーを設定して下さい。<br>
また、プライマリキーに設定したIdカラムにデータベースから自動で値が採番されるように次の画像のように設定して下さい。Idカラムを選択するとタブの下のほうにカラムのプロパティが表示されるので、そこでIdentity Specificationを開き、配下の(Is Identity)をクリックすれば自動採番するように切り替わります。<br>
完了したらCtrl + Sを押してテーブル名を入力するよう求められるのでUserと入力してOKをクリックして下さい。<br>
![SSMS7](https://private-user-images.githubusercontent.com/138543335/418843195-e775c8a2-0870-4669-95cb-bc500679fdcf.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEwNjQ5OTgsIm5iZiI6MTc0MTA2NDY5OCwicGF0aCI6Ii8xMzg1NDMzMzUvNDE4ODQzMTk1LWU3NzVjOGEyLTA4NzAtNDY2OS05NWNiLWJjNTAwNjc5ZmRjZi5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA0JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwNFQwNTA0NThaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1kOGYxZGIzNGI2ODZiMTUwYWU3MDNlNzI3ZWU2YzJiZGQ4NjIwMjVkMmYzNGNmYmYxNjBlYjhhNGMyYzNiNTM1JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.bCZCkk2SxFpkQO72uHoyArEQ1U9BdEXoKaakLNi2aAc)<br>
![SSMS8](https://private-user-images.githubusercontent.com/138543335/420159647-c30542fb-6aaa-48a5-8759-494200c4b1ee.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NDEzMTQyNDYsIm5iZiI6MTc0MTMxMzk0NiwicGF0aCI6Ii8xMzg1NDMzMzUvNDIwMTU5NjQ3LWMzMDU0MmZiLTZhYWEtNDhhNS04NzU5LTQ5NDIwMGM0YjFlZS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMzA3JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDMwN1QwMjE5MDZaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1mMDVmMTNkNTJlZjdmZDk5MmI3ZDIxYjViYzljMzE2ZTJmN2M0YjY0ZThkZGRjMjk5YWFlNzBlY2VjMDY5MTkxJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.FKx5mN94eF7W40SL1opOr66Etmo498IHpDt9X7Xw8-k)<br>
3.作成したテーブルにデータを入力します。Tables配下にdbo.Userというテーブルがあると思いますのでそれを右クリックしてEdit Top 200 Rowsをクリックすると画面右側にデータを入力するタブが表示されます。<br>そこでIdには半角で0以降の数値を入力し、Nameには好きな名前を入力しタブを閉じて下さい。先ほどと同様にdbo.Userを右クリックして今度はSelect Top 1000 Rowsをクリックして下さい。<br>すると画面右側に先ほど入力したデータが表形式で表示されるはずです。<br>
4.1~3のやり方でUserTodoという名前のテーブルを作成して下さい。
