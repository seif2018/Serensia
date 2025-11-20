## 🚀 SERENSIA – Moteur de suggestion de mots approchants


SERENSIA est un moteur de suggestion de mots approchants développé en **C# (.NET 10)** avec **Visual Studio 2026**.  
Il permet de comparer un mot recherché à une liste de termes et de proposer les mots les plus proches selon un scoring intelligent.  
Ce moteur est utile pour :

- systèmes de recherche intelligente  
- auto-complétion  
- correction orthographique  
- saisie assistée
   
---
## 🛠️ Technologies

- **Langage :** C#  
- **Framework :** .NET 10  
- **IDE :** Visual Studio 2026  

---

## 📦 Installation

1. Cloner le projet
2. Ouvrir dans Visual Studio

---

## 🧠 Fonctionnalités principale

- Analyse d’un terme à comparer  
- Calcul d’un score de similarité basé sur les différences de caractères  
- Utilisation de `ReadOnlySpan<char>` pour optimiser les performances  
- Tri intelligent des résultats (similarité → longueur → ordre alphabétique)  
- Retour des *N* meilleurs mots correspondants  
- Couche d’abstraction (`IAmTheTest`) permettant d'étendre ou remplacer facilement l’algorithme  

---

## 🏗️ Architecture du projet

Serensia.sln
├── Serensia/
│ ├── Program.cs
│ ├── Abstractions/
│ │ └── IAmTheTest.cs
│ └── Algorithms/
│ └── WordSuggester.cs
└── Serensia.Tests/
└── WordSuggesterTests.cs

---

## 👤 Auteur
**Seifeddine Trabelsi**  
Email : seifeddin.trabelsi@gmail.com
