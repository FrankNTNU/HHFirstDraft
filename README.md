HHFirstVersion專案方法簽名說明:
Member類別	
方法
GetMembers();
回傳會員清單
GetMembers(string);
回傳符合字串條件搜尋的會員清單
Add(Member);
新增一筆會員資料，回傳是否成功
Update(Member);
修改一筆會員資料
Delete(Member);
刪除一筆會員資料，回傳是否刪除成功
IsPwdExist(string);
回傳密碼是否已存在
IsEmailExist(string);
回傳信箱是否已存在
IsTaiwanIDExist(string);
回傳身份證字號是否已存在
================================
ActivityLevel類別
方法
GetLevels()
回傳活動等級的清單
================================
Status類別
方法
GetStatuses()
回傳狀態的清單
================================
Workout類別
方法
GetWorkouts() 
回傳運動項目的清單
GetWorkouts(string) 
回傳符合字串條件搜尋的運動項目清單
Add(Workout)
新增一筆運動項目，回傳是否成功
Update(Workout)
修改一筆運動項目
Delete(int)
刪除一筆運動項目，回傳是否刪除成功
IsWorkoutExist()
回傳運動項目是否存在
================================
WorkourCategory類別
方法
GetCategories()
回傳運動分類清單
Add(WorkoutCategory)
新增一筆運動分類，回傳是否成功
Update(WorkoutCategory)
修改一筆運動分類
Delete(int)
刪除一筆運動項目，回傳是否刪除成功
IsCategoryExist(string)
回傳該運動分類名稱是否已存在
HasWorkouts(int)
回傳該運動分類是否有存在所屬的運動項目
================================
Meal類別
方法
GetMeals()
回傳餐點清單
GetMeals(string)
回傳符合字串條件搜尋的餐點清單
Add(Meal)
新增一筆餐點，回傳是否成功
Update(Meal)
修改一筆餐點
Delete(ID)
刪除一筆餐點，回傳是否刪除成功
IsMealExist()
回傳該餐點名稱是否存在
================================
Tag類別
方法
GetTags()
回傳標籤清單
Add(Tag)
新增一筆標籤
Update(Tag)
修改一筆標籤
Delete(int)
刪除一筆標籤
IsTagExist(string)
回傳標籤名稱是否存在



