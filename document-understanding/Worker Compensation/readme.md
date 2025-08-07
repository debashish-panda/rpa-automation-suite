# 🤖📄 Document Understanding with UiPath AI Center

A robust end-to-end automation pipeline that extracts structured data from **unstructured insurance documents** using **UiPath Document Understanding**, AI/ML models, OCR, and Natural Language Processing — and stores it cleanly into a **relational database** for further processing.

> 💡 Supports **dispatcher-performer model**, integrated with **UiPath Queues**, and compatible with both **attended** and **unattended bots**.

---

## 🧠 What's Inside?

### 🔍 Core Capabilities:
- 📁 **Document Classification** (e.g., Homeowner, HCPC, Worker Comp)
- 🧠 **Image-based Classification Models** using UiPath AI Center
- 🔡 **OCR & NLP-powered** Text Extraction from scanned PDFs and images
- 🏷️ **Entity Extraction**: Premiums, Coverage, Duration, Policy Type, Additional Costs
- 🧾 **Document Type Detection** (even from mixed input folders)
- 🧠 **ChatGPT API Integration** for advanced NLP / natural language prompts
- 🗂️ **Queue-based Dispatcher-Performer Model** with exception handling
- 🛢️ **Structured Data Storage** in SQL/NoSQL Databases
- 📊 **Analytics Ready Output** for BI tools

---

## 🛠️ Technologies Used

| Tech                     | Purpose |
|--------------------------|---------|
| 🟣 UiPath Studio         | Orchestration & Workflow Logic |
| 🟡 UiPath AI Center      | ML Model Training & Deployment |
| 🟢 UiPath Document Understanding | OCR, Classification, Data Extraction |
| ⚙️ UiPath Orchestrator   | Queue Management |
| 🤖 Attended/Unattended Bots | Flexible Deployment Modes |
| 📦 UiPath Queues         | Dispatcher & Performer Job Handling |
| 📄 Tesseract / OmniPage OCR | Image & PDF Text Extraction |
| 🧠 OpenAI GPT API        | Natural Language Understanding |
| 🛢️ PostgreSQL / SQL Server | Data Storage |
| 🧪 Regex, ML & Rules     | Hybrid Extraction Techniques |

---

## 🚀 How It Works

1. ✅ User or bot **uploads documents** (PDFs, scanned images)
2. 🧠 ML models **classify the document type**
3. 🔍 OCR & NLP pipelines **extract relevant data**
4. 🔄 Data is sent to **UiPath Queue (Dispatcher)**
5. 🤖 Performer bot **processes queue items**
6. 🛢️ Extracted data is saved to **SQL database**
7. 📊 Final result is **ready for analytics or further workflow**

---

## 💻 Requirements

- UiPath Studio (2023+)
- UiPath AI Center (for ML model training/deployment)
- UiPath Orchestrator
- Database (PostgreSQL / MSSQL)
- OpenAI API Key (for GPT integration)
- OCR Engines (Tesseract, OmniPage, Google OCR)

---

## 📌 Notes

- Add your AI Center ML skill name under **Document Classification Scope**
- Configure **Queue Names** in both dispatcher and performer workflows
- OCR accuracy depends on **scan quality and engine choice**
- GPT calls should be **rate-limited** in production use

---

## 🤝 Contribution

We welcome your improvements, suggestions, and bug fixes!
- Create an issue
- Fork the repo
- Submit a PR

---


