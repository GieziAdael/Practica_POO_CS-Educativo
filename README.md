# Práctica de Programación Orientada a Objetos en C#

Este proyecto es una práctica educativa de **Programación Orientada a Objetos (POO)** en C#.  
Se implementan clases que representan seres vivos (como `Perro` y `Gato`) con atributos, constructores y métodos, aplicando los pilares de la POO: **abstracción, encapsulamiento, herencia y polimorfismo**.

---

## 🚀 Características principales
- **Clases y Objetos**: Definición de `Ser_Vivo` como clase base y `Perro`, `Gato` como clases derivadas.
- **Herencia**: `Perro` y `Gato` heredan de `Ser_Vivo`.
- **Polimorfismo**: Métodos sobreescritos (`override`) como `Comunicar()`.
- **Encapsulamiento**: Uso de modificadores de acceso (`private`, `protected`, `public`) para controlar la visibilidad de atributos.
- **Constructores**: Inicialización de objetos con parámetros personalizados.
- **Métodos propios**: Por ejemplo, `Ladrar()` en `Perro`.

---

## 📂 Estructura del proyecto
📦 Practica_POO_CS
┣ 📜 Program.cs -> Punto de entrada del programa
┣ 📜 Ser_Vivo.cs -> Clase base con atributos y métodos generales
┣ 📜 Perro.cs -> Clase derivada que hereda de Ser_Vivo
┣ 📜 Gato.cs -> Clase derivada que hereda de Ser_Vivo
┗ 📜 README.md -> Documentación del proyecto

---

## 🛠️ Tecnologías utilizadas
- Lenguaje: **C# (.NET 9.0)**
- IDE: **Visual Studio 2022**

---

## ▶️ Ejemplo de uso
// Crear objetos
Perro miPerro = new Perro(20.5, 80, 70, 60, 90, 50);
Gato miGato = new Gato(10.2, 60, 50, 70, 85);

// Invocar métodos
miPerro.Comunicar();   // El perro ladra
miPerro.Ladrar();

miGato.Comunicar();    // El gato maulla
