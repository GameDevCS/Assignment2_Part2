# Unity Basics - Part 2

Mini-Map and Cameras

---

## מה יש בפרויקט

1. Mini-Map - מפה קטנה בפינה ימנית עליונה
2. Player Movement - תנועת שחקן עם חיצים
3. Camera Follow - מצלמה שעוקבת אחרי השחקן
4. Camera Aspect Fixer - תיקון גודל בסיבוב מסך

---
## הסבר על למה הגודל משתנה כאשר מסובבים את המסך.?

במצלמה אורתוגרפית (Orthographic), השדה Orthographic Size קובע את חצי הגובה של המסך במטרים.

כשמסובבים את המסך למצב אנכי:
 הגובה נשאר אותו דבר (Orthographic Size לא משתנה) אבל הרוחב נעשה קטן יותר

ולכן התוכן נדחס לרוחב קטן יותר, מה שגורם לעצמים להיראות גדולים יותר יחסית למסך.

הפתרון: הסקריפט CameraAspectFixer משנה את orthographicSize בהתאם ליחס המסך, כדי לשמור על גודל יחסי קבוע.

---

## איך להריץ

1. פתח את הפרויקט ב-Unity
2. פתח את הסצנה MiniMapScene
3. לחץ Play
4. השתמש בחיצים כדי לזוז

---

## טכנולוגיות

Unity 6000.0.28f1
C# Scripts

---

## קבצים חשובים

Assets/Scripts - כל הסקריפטים
Assets/Scenes/SampleScene - הסצנה הראשית

---

## קישורים

משחק: https://davidstern135.itch.io/assignment2-part2
קוד: https://github.com/GameDevCS/Assignment_2_Part2

---

חלק 2 מתוך 2
