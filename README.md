# DB接続文字
## appsettings.jsonファイルのMyConnectionに対応する接続文字列のUser IdとPasswordの値をサーバーに登録したログインユーザーの名前とパスワードに書き換えて下さい。以降のステップでも同様に書き換えて下さい。

## Step2でやること
Step2の目標1：WebApplication2/Views/Home/Home.cshtmlファイルの演習用のHTMLを追加して下さい。<br>
Step2の目標2：WebApplication2/Controllers/HomeContoroller.csファイルのClickGetDataTodo()を修正してHomeControllerクラスのGetDataTodo()から取得したデータをテーブルに表示させて下さい。<br>
Step2の目標3：WebApplication2/Service/HomeService.csファイルのGetDataServiceTodoメソッドを修正し、データベースコンテキストから取得したデータをhomeViewModelに格納して、それらをリスト化して返すようにして下さい。
