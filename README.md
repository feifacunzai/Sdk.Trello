#Sdk.Trello
讓開發者使用TrelloAPI存取資料

## 專案
實作TrelloAPI的基本存取功能，提供Board、List、Card等...CRUD操作。

## 安裝
下載後使用Visual Studio的參考管理員，將專案加入至參考。
  
## 程式範例
```c#
//查詢已建立的看板
public List<BoardEntity> Main(string key, string token, string username)
{
    var memberService = new MemberService(key, token);
    return memberService.Boards(username);
}
```  
