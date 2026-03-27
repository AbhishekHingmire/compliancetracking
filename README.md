# RegWatch India — Regulatory Compliance Tracking SaaS

> **Never miss a government regulation change again.**  
> RegWatch monitors 40+ Indian regulatory bodies (CBIC, SEBI, EPFO, MCA, FSSAI, RBI and more) and alerts your business in plain English and Hindi before deadlines hit.

---

## 🏗️ Solution Architecture

```
compliancetracking.slnx
└── src/
    ├── RegWatch.Core/            ← Domain layer (entities, enums, DTOs, interfaces, validators)
    ├── RegWatch.Infrastructure/  ← Data layer (EF Core DbContext, service stubs, DI)
    ├── RegWatch.Api/             ← REST API (JWT auth, Swagger, 5 API controllers)
    └── RegWatch.Web/             ← MVC frontend (Tailwind CSS, Alpine.js, Lucide icons)
        ├── Controllers/          ← 10 MVC controllers
        ├── Models/
        │   ├── ViewModels/       ← 10 typed ViewModels
        │   └── (entities in Core)
        ├── Middleware/           ← ExceptionHandling, RequestLogging, TenantResolution
        ├── Helpers/              ← DateTimeHelper, CurrencyHelper, PriorityHelper, StringExtensions
        └── Views/                ← 25 complete Razor/Tailwind views
```

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Framework | .NET 8 ASP.NET Core MVC |
| ORM | Entity Framework Core 8 + Npgsql (PostgreSQL) |
| API Auth | JWT Bearer tokens |
| API Docs | Swagger / OpenAPI |
| Background Jobs | Hangfire (wired, pending implementation) |
| Frontend CSS | Tailwind CSS via CDN |
| Frontend JS | Alpine.js (reactivity), Lucide Icons |
| Fonts | Inter (Google Fonts) |

---

## 📋 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- PostgreSQL 15+ (for future backend integration)

---

## 🚀 Quick Start

```bash
# 1. Clone the repository
git clone https://github.com/AbhishekHingmire/compliancetracking.git
cd compliancetracking

# 2. Restore packages
dotnet restore

# 3. Run the web app (UI only — no DB needed)
cd src/RegWatch.Web
dotnet run

# App will be available at https://localhost:5001
```

---

## 📄 Views (25 complete pages)

| Page | Route | Description |
|------|-------|-------------|
| Landing | `/` | Hero, features, testimonials, pricing CTA |
| Pricing | `/home/pricing` | 3-tier plans, ROI calculator, FAQ |
| About | `/home/about` | Mission, values, team |
| Contact | `/home/contact` | Contact form |
| Login | `/auth/login` | Email/password with remember me |
| Register | `/auth/register` | Account creation with password strength |
| Dashboard | `/dashboard` | Stats, recent alerts, deadlines, activity chart |
| Alerts List | `/alerts` | Filterable alert feed with search |
| Alert Detail | `/alerts/detail/:id` | Full detail, bilingual summary, checklist, impact |
| Reg. Library | `/regulation/library` | Table/grid toggle, search, filter |
| Profile Setup | `/profile/setup` | 4-step onboarding wizard |
| Notifications | `/settings/notifications` | All alert preference toggles |
| Billing | `/billing/plans` | Plan comparison, invoices, payment method |
| Monthly Report | `/reports/monthly` | Stats, body breakdown, savings, PDF download |
| Admin | `/admin/dashboard` | Platform health, scraping status, tenant list |

---

## 🔌 API Endpoints (RegWatch.Api)

All API routes are prefixed with `/api/` and require JWT Bearer authentication.

| Controller | Routes |
|-----------|--------|
| Auth | `POST /api/auth/login`, `POST /api/auth/register` |
| Alerts | `GET /api/alerts`, `GET /api/alerts/{id}`, `PATCH /api/alerts/{id}/status` |
| Regulations | `GET /api/regulations`, `GET /api/regulations/{id}` |
| Dashboard | `GET /api/dashboard/stats` |
| Reports | `GET /api/reports/monthly` |

Swagger UI: `https://localhost:5003/swagger`

---

## 🏛️ Domain Entities (10)

`Tenant`, `User`, `Regulation`, `Alert`, `RegulatoryBody`, `Deadline`, `NotificationPreference`, `Subscription`, `Invoice`, `ScrapeLog`

---

## 🔧 Configuration

Update `src/RegWatch.Web/appsettings.json` with your real values:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=regwatch;Username=postgres;Password=YOUR_PASSWORD"
  }
}
```

---

## 📦 Status

| Feature | Status |
|---------|--------|
| All 25 Views (UI) | ✅ Complete |
| 4-project architecture | ✅ Complete |
| Entity models + validation | ✅ Complete |
| Service interfaces | ✅ Complete |
| Service implementations | 🔄 Stub — ready for backend logic |
| Database queries (LINQ) | ⏳ Planned next sprint |
| Authentication flow | ⏳ Planned next sprint |
| Hangfire background jobs | ⏳ Planned next sprint |
| Web scraping | ⏳ Planned next sprint |

---

## 📜 License

MIT © 2024 RegWatch India Pvt. Ltd.
