請先完成下列動作才得執行該專案。
(1) 先去我們的Google雲端硬碟復原最新的DB。
(2) 在專案的DAL檔案下加入實體模型。(DAL右鍵新增項目>實體資料模型>設定連線>選tables並勾選自動複數名稱)
(3) 記得去DAL>DAO>HHContext.cs修改實體模型的名稱。(設定實體資料庫變數名稱，例如改成public HealthManagementEntities db = new HealthManagementEntities())
