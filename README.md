# PhoneStore Management System

PhoneStore Management System is a Database Management System (DBMS) final project for managing a mobile phone store. The application is built with C# (WinForms, .NET Framework) and SQL Server to handle products, imports, sales, customers, employees, warranties, promotions and notifications.

This project was developed during the author's second year at university.

---

## ✨ Key Features

- 🔐 Login system with role-based access — current user & role stored in `Session`.
- 📊 Dashboard with summary information (revenue, orders, alerts).
- 📦 Product management:
  - Product models, technical specs, product codes and IMEI/serial handling.
  - Warranty management, product status, and stock quantity checks (fn_Get_Stock_Quantity function).
- 🛒 Sales management:
  - Create sales orders using a TVP (table-valued parameter) for order details.
  - Select customer, employee, apply promotion, payment method, and manage order status.
  - Revenue statistics by date range (fn_TotalRevenue function).
- 📥 Import / Purchase orders:
  - Create import orders from suppliers with multiple detail rows and total calculation.
- 👥 People management:
  - Customer CRUD and search by phone number.
  - Employee and user account management.
- 🔔 Notifications:
  - Periodic notification checks with an alert icon and a notification form.
- 🖼️ Product image management (see `ProductPictures` folder and AddPicture form).
- 🧭 Additional helpers: Nominatim integration, global state via `GlobalState`.

---

## 🛠️ Tech Stack

| Technology                                                   | Purpose                                        |
| :----------------------------------------------------------- | :--------------------------------------------- |
| C# (.NET Framework 4.8)                                      | WinForms desktop application                   |
| WinForms                                                     | User interface (forms & user controls)         |
| ADO.NET / Stored Procedures                                  | DB access helper (`DBMain.cs`)                 |
| SQL Server (PHONESHOP DB, stored procedures, functions, TVP) | Data storage and business logic                |
| EntityFramework (present in packages folder)                 | Included package if you want to extend with EF |

---

## ⚙️ Requirements & Setup

1. Required software:

   - Windows with Visual Studio (recommended VS 2019/2022) and .NET Framework 4.8.
   - SQL Server (Express/Developer) and SQL Server Management Studio (SSMS) recommended.

2. Restore the database:

   - The repository contains `PHONESHOP.bak` (database backup). Restore this file into your SQL Server instance using SSMS.
   - Alternatively use a T-SQL restore command if preferred.

3. Connection string:

   - By default the connection string is set in `PhoneStore\\PhoneStore\\Database\\DBMain.cs` (variable `ConnStr`):
     "Data Source=htruc;Initial Catalog=PHONESHOP;Integrated Security=True;TrustServerCertificate=True"
   - Replace `Data Source` with your SQL Server instance name or change to SQL authentication. You may also move the connection string into `App.config` for easier configuration.

4. Open and run the project:
   - Open `PhoneStore\\PhoneStore.sln` in Visual Studio.
   - Set `PhoneStore` project as the startup project.
   - Build and run. The application will start with the login form (`frmLogin`).

Note: The app relies on stored procedures, functions and a TVP type (e.g., `SaleDetailType`). Make sure the `PHONESHOP` database is restored correctly to avoid runtime errors when procedures/functions are called.

---

## 📁 Main project structure

Important folders & files:

- `PhoneStore/PhoneStore.sln` - solution file.
- `PhoneStore/PhoneStore/Database/DBMain.cs` - DB connection and ADO.NET helper.
- `PhoneStore/PhoneStore/Forms/` - all forms and user controls (MainForm, frmLogin, ucProduct, ucImport, ucSale, etc.).
- `PhoneStore/PhoneStore/Business/` - business classes (Product, ProductModel, SaleOrder, ImportOrder, Customer, Employee, Login, Notification...).
- `PhoneStore/PhoneStore/AdditionalFunctions/` - helpers such as `Session`, `GlobalState`, `Nominatim`.
- `PHONESHOP.bak` - database backup (restore this before running the app).

---

## 📷 UI & Preview

The application is a WinForms desktop app with multiple UserControls for modules such as Dashboard, Product Management, Import, Sale, User Management, Warranty, and Promotion. The `ProductPictures` folder stores product images.

<img width="519" height="280" alt="image" src="https://github.com/user-attachments/assets/9dad6a18-bed1-4f3e-a1ca-db2f061a4735" />

<img width="787" height="443" alt="image" src="https://github.com/user-attachments/assets/70c2f229-1447-47f0-a91b-ac6f50f7d8a9" />

---

## 📌 Operational notes

- Login: the app uses stored procedures `VerifyLogin` and `GetUserInfo` to authenticate and retrieve the user role. If login fails, check the users data in the DB.
- Sales: when creating a sale order, the app sends a TVP `SaleDetailType` to the stored procedure `sp_Insert_Sale_Order_Full`.
- Imports: import order details are collected into a DataTable and sent via `ImportOrder` business class to the DB.
- Notifications: notifications are polled on a timer and an alert icon is shown when there are new notifications.

---

## 🧪 Quick local test

1. Restore `PHONESHOP.bak` into your SQL Server instance.
2. Open the solution in Visual Studio.
3. Build (Ctrl+Shift+B). If packages are missing, run NuGet restore.
4. Run the project (F5). Login using an account stored in the `PHONESHOP` database. If no users exist, insert a test user directly into the DB or seed the required data.

---

## 🙌 Acknowledgements

- This project was built as an academic assignment to practice database management, desktop application development, and ADO.NET.
- Thanks to instructors, classmates and online resources that helped during development.

---

## 📄 License

This project is open source and available under the **MIT License**.

## 🤝 Contact & Support

If you encounter any issues or have questions about this project, feel free to reach out:

- 📧 Email: huytranquoc24@gmail.com
- 🌐 Facebook: https://www.facebook.com/huy.tranquoc.129357/
- 💼 LinkedIn: https://www.linkedin.com/in/tran-quoc-huy-0612-ai/

---

## 👨‍💻 Project Team

💡 Created with ❤️ by:

- **Tran Quoc Huy** - 23110026
- **Le Huu Truc** - 23110068
- **Trac Van Ngoc Phuc** - 23110057
- **Hoang Duc Tuan** - 23110069
