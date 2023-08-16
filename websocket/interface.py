import sys
from PyQt5.QtWidgets import QApplication, QWidget, QPushButton

def on_click():
    print("Botão clicado!")

app = QApplication(sys.argv)
window = QWidget()
window.setWindowTitle("Minha Janela")

button = QPushButton("Clique aqui", window)
button.clicked.connect(on_click)

window.show()
sys.exit(app.exec_())
