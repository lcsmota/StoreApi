# StoreApi
<img src="https://user-images.githubusercontent.com/118696036/230089636-61af1264-eeb8-48c5-b1d8-1132d8d2d17b.png" />

#
## <img src="https://icon-library.com/images/database-icon-png/database-icon-png-13.jpg" width="20" /> Database

_Create a database in SQLServer that contains the table created from the following script:_
```sql
CREATE DATABASE StoreDapper
GO

USE StoreDapper
GO

CREATE TABLE Stores(
    StoreId INT PRIMARY KEY IDENTITY(1, 1),
    StoreName VARCHAR(255) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Street VARCHAR(255) NOT NULL,
    City VARCHAR(80) NOT NULL,
    State VARCHAR(40) NOT NULL
);
GO
```

### Relationships
```yaml
+--------------+
|    Stores    |
+--------------+
| StoreId      |
| StoreName    |
| Phone        |
| Email        |
| Street       |
| City         |
| State        |
+--------------+ 
```
#
## 🌐 Status
<p>Finished project ✅</p>

#
## 🧰 Prerequisites

- .NET 6.0 or +

- Connection string to SQLServer in StoreApi/appsettings.json named as Default
#
## 🔧 Installation

`$ git clone https:/github.com/lcsmota/StoreApi.git`

`$ cd StoreApi/`

`$ dotnet restore`

`$ dotnet run`

**Server listenning at  [https:/localhost:7161/swagger](https:/localhost:7161/swagger) or [https:/localhost:7161/api/Stores](https:/localhost:7161/api/Stores)**

#
# 📫  Routes for Stores

### Return all objects (Stores)
```http
  GET https://localhost:7161/api/Stores
```
⚙️  **Status Code:**
```http
  (200) - OK
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230077522-74b69348-6ad2-4de2-8fcb-d2fa97543e7d.png" />

#### 📝  Swagger
<img src="https://user-images.githubusercontent.com/118696036/230077548-2b31fed4-4dfa-4af5-bd99-23c535f5d417.png" />

#
### Return only one object (Store)

```http
  GET https://localhost:7161/api/Stores/${id}
```

| Parameter   | Type       | Description                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Mandatory**. The ID of the object you want to view|

⚙️  **Status Code:**
```http
  (200) - OK
  (404) - Not Found
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230077948-65b831c3-c647-4c46-8d9b-8dfb1f8b99b7.png" />
<img src="https://user-images.githubusercontent.com/118696036/230078274-dc179af4-dcca-4267-a599-68e8447856a2.png" />

#### 📝  Swagger
<img src="https://user-images.githubusercontent.com/118696036/230077961-c1324097-5927-4f22-bebe-f989c1f69937.png" />
<img src="https://user-images.githubusercontent.com/118696036/230078287-368283c4-4da6-4ddb-b752-6c5e0e412bcc.png" />

#
### Insert a new object (Store)

```http
  POST https://localhost:7161/api/Stores
```
📨  **body:**
```
{
  "storeName": "World Evolution",
  "phone": "334567891234",
  "email": "worldevol@mail.io",
  "street": "Rua 238",
  "city": "Tecnolandia",
  "state": "Titech"
}
```

🧾  **response:**
```
{
    "storeId": 1008,
    "storeName": "World Evolution",
    "phone": "334567891234",
    "email": "worldevol@mail.io",
    "street": "Rua 238",
    "city": "Tecnolandia",
    "state": "Titech"
}
```

⚙️  **Status Code:**
```http
  (201) - Created
  (400) - Bad Request
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230079593-327ca9e4-6a58-4753-93e6-679de268b202.png" />
<img src="https://user-images.githubusercontent.com/118696036/230080820-f61c16f4-5f9b-49df-9ee1-577c01ac810f.png">

#### 📝  Swagger
<img src="https://user-images.githubusercontent.com/118696036/230079613-a31f3878-273a-4dce-afc9-3bfcb74bd2c0.png" />
<img src="https://user-images.githubusercontent.com/118696036/230079889-001c82ad-aeec-4e2b-baa8-b4b7f29d0077.png" />
<img src="https://user-images.githubusercontent.com/118696036/230080833-e9caf592-5975-4d97-a522-292c338fc286.png">
<img src="https://user-images.githubusercontent.com/118696036/230080848-7fe7b0f2-6680-425e-9891-1441f0ff1a60.png">

#
### Update an object (Store)

```http
  PUT https://localhost:7161/api/Stores/${id}
```

| Parameter   | Type       | Description                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Mandatory**. The ID of the object you want to update|

📨  **body:**
```
{
  "storeId": 1008,
  "storeName": "World Evolution X",
  "phone": "334567891234",
  "email": "worldevol@mail.io",
  "street": "Rua 138",
  "city": "Tecnolandia",
  "state": "Titech"
}
```
🧾  **response:**
```http
true
```

⚙️  **Status Code:**
```http
  (200) - OK
  (400) - Bad Request
  (404) - Not Found
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230083376-890e0f52-71ad-441b-97d7-c73d22177d77.png" />
<img src="https://user-images.githubusercontent.com/118696036/230083821-f0dd0d75-8efb-48e1-8569-86898023f231.png" />
<img src="https://user-images.githubusercontent.com/118696036/230078274-dc179af4-dcca-4267-a599-68e8447856a2.png" />

#### 📝  Swagger
<img src="https://user-images.githubusercontent.com/118696036/230082545-2eb2aff6-52ec-44fb-a13a-c51aeefeed46.png" />
<img src="https://user-images.githubusercontent.com/118696036/230082556-9d34191a-0337-4f78-9b5f-25ad42ebb532.png" />
<img src="https://user-images.githubusercontent.com/118696036/230081983-0ecfb9a3-eae8-443d-9724-96acbc5e60d4.png" />
<img src="https://user-images.githubusercontent.com/118696036/230082000-7c9abb47-17aa-4d03-bb1f-bb0b753de267.png" />
<img src="https://user-images.githubusercontent.com/118696036/230078287-368283c4-4da6-4ddb-b752-6c5e0e412bcc.png" />

#
### Delete an object (Store)
```http
  DELETE https://localhost:7161/api/Stores/${id}
```

| Parameter   | Type       | Description                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Mandatory**. The ID of the object you want to delete|

📨  **body:**

🧾  **response:**

⚙️  **Status Code:**
```http
  (204) - No Content
  (404) - Not Found
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230084280-11284227-79e3-4cbb-bba3-11ee263352ab.png" />
<img src="https://user-images.githubusercontent.com/118696036/230078274-dc179af4-dcca-4267-a599-68e8447856a2.png" />

#### 📝  Swagger
<img src="https://user-images.githubusercontent.com/118696036/230084294-51a31f98-06ea-4096-acea-8de332d003a5.png" />
<img src="https://user-images.githubusercontent.com/118696036/230078287-368283c4-4da6-4ddb-b752-6c5e0e412bcc.png" />

#
## 🔨 Tools used

<div>
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="80" />
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="80" />
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain-wordmark.svg" width=80/>
</div>

# 🖥️ Technologies and practices used
- [x] C# 10
- [x] .NET CORE 6
- [x] SQL SERVER
- [x] Dapper Contrib
- [x] Swagger
- [x] FluentValidation
- [x] Repository Pattern
- [x] Dependency injection
- [x] POO

# 📖 Features
Registration, Listing, Update and Removal
