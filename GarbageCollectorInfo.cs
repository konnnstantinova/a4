using System;
using System.Drawing;
using System.Windows.Forms;

namespace GarbageCollectorInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGCInfo();
        }

        private void LoadGCInfo()
        {
            string gcInfo = @"Сборщик мусора (Garbage Collector) в .NET

Сборщик мусора автоматически управляет памятью в .NET приложениях.

Основные принципы:
• Автоматическое освобождение памяти
• Поколения объектов (0, 1, 2)
• Алгоритм Mark and Sweep
• Компактификация кучи

Методы GC класса:
• GC.Collect() - принудительная сборка
• GC.GetTotalMemory() - объем используемой памяти
• GC.WaitForPendingFinalizers() - ожидание финализаторов

Рекомендации:
• Избегайте принудительного вызова GC.Collect()
• Используйте using для IDisposable объектов
• Минимизируйте создание объектов в циклах";

            infoTextBox.Text = gcInfo;
        }

        private void collectButton_Click(object sender, EventArgs e)
        {
            long memoryBefore = GC.GetTotalMemory(false);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            long memoryAfter = GC.GetTotalMemory(false);
            
            MessageBox.Show($"Память до сборки: {memoryBefore} байт\nПамять после сборки: {memoryAfter} байт\nОсвобождено: {memoryBefore - memoryAfter} байт");
        }
    }
}