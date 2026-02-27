# FlujoDeControl_1 - Calcular-ISR
 Calcular el ISR (Impuesto Sobre la Renta) en Republica Dominicana, De acuerdo con una escala salarial disponible en la plataforma de la DGII


Este proyecto permite:

- Leer el sueldo mensual de un empleado

- Determinar si aplica ISR

- Calcular el monto a pagar según la tabla oficial

- Mostrar el sueldo y el ISR correspondiente

- Mostrar N/A cuando el empleado está exento

- El cálculo se basa en la escala progresiva publicada por la DGII para el año vigente.

#### Escala de ISR utilizada (RD)

| Renta anual (RD$)          | ISR                               |
|-----------------------------|------------------------------------|
| Hasta 416,220.00            | Exento                             |
| 416,220.01 – 624,329.00     | 15% del excedente                  |
| 624,329.01 – 867,123.00     | 31,216 + 20% del excedente         |
| Más de 867,123.01           | 79,776 + 25% del excedente         |

Equivalente aproximado mensual exento: *RD$34,685*

#### ⚙️ Funcionamiento del programa

1. El usuario introduce el sueldo mensual.
2. El sistema calcula el sueldo anual (sueldo × 12).
3. Se identifica el tramo correspondiente.
4. Se calcula el ISR según la fórmula del tramo.
5. Se muestra el resultado final.

#### 💻 Capturas del programa en ejecución

##### 🔹 Escenario 1 – Sueldo Exento

<img width="299" height="155" alt="image" src="https://github.com/user-attachments/assets/36e79686-7b4d-4f89-adce-5972e0665feb" />


##### 🔹 Escenario 2 – Sueldo que paga ISR

<img width="300" height="152" alt="image" src="https://github.com/user-attachments/assets/c3383c56-0b99-48e5-8646-a81c86794dd3" />


#### 📂 Estructura del proyecto


```
FlujoDeControl_1_Calcular-ISR
│── FlujoDeControl_1
│   └── Program.cs
│── README.md
└── imagenes
    ├── escenario1.png
    └── escenario2.png
```

#### 🛠️ Tecnologías utilizadas

- Lenguaje: C#
- Tipo: Aplicación de consola
- Estructuras condicionales (if / else)
- Operaciones matemáticas

  #### 🎯 Objetivo académico

Desarrollar un programa que permita aplicar estructuras de decisión
y cálculos matemáticos para resolver un problema real basado en
la legislación fiscal dominicana.

#### 👤 Autor

*Nombre Completo:* Enyel Jovier Torres Santana

*Matrícula:* 2025-0308  

*Asignatura:* Programacion Basica  

*Profesor:* Gamalier Reyes
