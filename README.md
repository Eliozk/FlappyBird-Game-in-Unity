# משחק פלאפי בירד

משחק דו-ממדי (2D) בהשראת המשחק הקלאסי Flappy Bird. השחקן שולט בציפור שצריכה לעבור מכשולים של צינורות ולהימנע מהתנגשות בקרקע. המשחק כולל ספירת ניקוד, מנגנון Game Over, ואתגרים שמתגברים ככל שהשחקן מתקדם.

[קישור למשחק ברמה בסיסית](https://kolanieliozgmailcom.itch.io/flappy-bird-game)

---

## **תכונות עיקריות**

### 🎮 **מכניקות משחק**
- **שליטה בציפור:** השחקן שולט בתנועת הציפור על ידי לחיצה או הקשה.
- **גרביטציה:** הציפור נמשכת מטה כל הזמן, מה שמצריך תזמון מדויק.
- **מעבר בין מכשולים:** צינורות נוצרים באופן דינמי, ויש לעבור דרך הרווחים ביניהם.
- **ספירת נקודות:** הניקוד עולה ככל שהציפור עוברת את המכשולים בהצלחה.

### 💥 **מצבי משחק**
- **התחלה:** המשחק מתחיל במצב עצירה עם כפתור התחלה.
- **משחק:** השחקן שולט בציפור ומתחיל לצבור נקודות.
- **סיום משחק:** אם הציפור מתנגשת בצינור או בקרקע, המשחק נגמר עם הודעת "Game Over" ואפשרות להתחיל מחדש.

---

## **איך משחקים**

1. **התחלת המשחק:**
   - לחץ על כפתור **Play** כדי להתחיל.
2. **שליטה בציפור:**
   - **מחשב:** לחץ על מקש הרווח או על העכבר כדי לגרום לציפור לעוף.
   - **נייד:** הקש על המסך כדי לגרום לציפור לעוף.
3. **הימנע ממכשולים:**
   - עבור דרך הרווחים שבין הצינורות.
4. **צבור נקודות:**
   - קבל נקודה על כל מעבר מוצלח דרך צינור.
5. **התחלה מחדש:**
   - לאחר Game Over, לחץ על כפתור Play כדי לנסות שוב.

---

## **תיאור הקוד**

### 📜 **סקריפטים**

#### **Player.cs**
אחראי על התנועה והאנימציות של הציפור:
- שולט בתנועת הציפור כלפי מעלה על פי קלט מהמשתמש.
- מפעיל את כוח המשיכה על הציפור.
- מזהה התנגשויות עם מכשולים או הקרקע.
- מנהל את אנימציית התנועת הכנפיים של הציפור.

#### **GameManager.cs**
אחראי על ניהול מצב המשחק וה-UI:
- מנהל את מצבי ההתחלה, העצירה והסיום.
- מעדכן את הניקוד ומציג אותו ב-UI.
- עוצר את המשחק במקרה הצורך.

#### **Spawner.cs**
אחראי על יצירת המכשולים:
- יוצר צינורות במרווחי זמן קבועים.
- משנה את גובה הצינורות כדי להוסיף אתגר.

#### **Parallax.cs**
מוסיף אפקט גלילה לרקע ולקרקע:
- מדמה עומק על ידי תנועה איטית של הרקע לעומת החזית.

---

## **נכסים במשחק**

### 🖼️ **תמונות**
- **ציפור:** אנימציות של תנועת כנפיים.
- **צינורות:** תמונות של מכשולים (צינורות עליונים ותחתונים).
- **רקע:** תמונה חוזרת של רקע המשחק.
- **קרקע:** תמונה של הקרקע עם גלילה מתמדת.

### 📜 **סקריפטים**

קוד המשחק, כולל Player.cs, GameManager.cs, Spawner.cs, ו-Parallax.cs, ניתן לצפייה ולעריכה בקישור:
[Assets/Scripts](https://github.com/Eliozk/FlappyBird-Game-in-Unity/tree/main/Assets/Scripts)


---

## **מידע למפתחים**

### 🚀 **טכנולוגיות בשימוש**
- **Unity Engine:** גרסה 2021 או חדשה יותר.
- **C#:** לשימוש במכניקות ותהליכים במשחק.
- **TextMeshPro:** להצגת טקסטים (כמו ניקוד, Game Over וכו').

### 🛠️ **הוראות התקנה**
1. שכפל את הפרויקט:
   ```bash
   git clone https://github.com/username/FlappyBirdClone.git
