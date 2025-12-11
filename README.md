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

1. Le mot recherché est converti en minuscules et transformé en `ReadOnlySpan<char>`.  
2. Chaque mot de la liste est analysé si sa longueur est suffisante.  
3. Le système compare les caractères via un `IDifferenceCalculator`.  
4. Pour chaque mot :
   - on calcule la différence minimale
   - on calcule l’écart de longueur
   - on enregistre toutes les informations
5. Le moteur trie ensuite :
   - par score de différence
   - par différence de longueur
   - par ordre alphabétique
6. Le moteur retourne les **N meilleures suggestions**.

---

## 🧪 Tests unitaires (xUnit)

La solution contient des tests couvrant :

### ✔ `DifferenceCalculator`
- Vérification des scores de différences
- Validation des erreurs si les tailles ne correspondent pas

### ✔ `WordSuggester`
- Vérification du tri final
- Filtrage correct des mots trop courts
- Exactitude des résultats pour le cas fourni par le lead

Ces tests assurent la stabilité et la maintenabilité du système.

---

## 🏗️ Architecture du projet

Serensia.sln
├── Serensia/
│   ├── Program.cs
│   ├── Abstractions/
│   │   ├── IAmTheTest.cs
│   │   └── IDifferenceCalculator.cs
│   ├── Algorithms/
│       ├── WordSuggester.cs
│       └── DifferenceCalculator.cs
│   
└── Serensia.Tests/
    ├── WordSuggesterTests.cs
    └── DifferenceCalculatorTests.cs


---

## 📌 Notes

Ce projet a été conçu pour démontrer :

- la capacité à produire un code propre et structuré  
- la maîtrise des concepts .NET modernes  
- l’application de principes comme SRP, DIP, et le refactoring orienté test  
- la compréhension des priorités d’un lead technique (architecture, testabilité, performance)

---

## 👤 Auteur
**Seifeddine Trabelsi**  
Email : seifeddin.trabelsi@gmail.com


