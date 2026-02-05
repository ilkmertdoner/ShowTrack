# ShowTrack 🎬
**ShowTrack** is a professional movie tracking and information platform developed in C# using a multi-layer architecture. It allows users to discover, search, and manage their favorite films using real-time data from the IMDb API.

## 🚀 Key Features (Implemented)
* **Dynamic Search Engine**: Real-time movie searching using the IMDb API.
* **Top 5 Popularity List**: A dynamic section on the home screen that sorts movies based on their `#RANK` value using LINQ.
* **Secure Authentication**: Automated 6-digit verification code delivery via Gmail SMTP.
* **Modern Navigation**: A centralized `MainForm.Instance` system for seamless transitions.

## 🛠 Tech Stack
| Category | Technology |
| :--- | :--- |
| **Language** | C# (.NET WinForms) |
| **Architecture** | N-Tier (Multi-Layer) |
| **Database** | MS SQL Server (LocalDB) & Entity Framework Core |
| **Data Format** | JSON (System.Text.Json) |
| **Communication** | HttpClient & SMTP Client |

## 📅 Roadmap (Upcoming)
1. **Logout Logic**: Secure session termination.
2. **Profile Management**: Email and password update portal.
3. **Enhanced Visuals**: Custom green & black theme assets.
