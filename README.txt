Proyeto: arreglosCSharp

Proyecto académico en C# que aplica arreglos y listas para organizar datos, con énfasis en encapsulación, herencia básica y principios de programación limpia.

## Objetivos
- Comprender y aplicar arreglos en C#.
- Implementar recorridos y cálculos sobre colecciones.
- Practicar encapsulación y herencia básica.
- Aplicar principios SOLID, KISS, TRY y YAGNI.

## Pilares aplicados
- **Encapsulación:** propiedades en `curso` y `pregrado`.  
- **Herencia:** `pregrado` hereda de `curso`.  

## Conversiones
- Implícitas: intensidad horaria semanal (`string` → `double`).  
- Explícitas: conversión nota mínima aprobatoria semanal (`double` → `int`). conversión código curso(`string` →`int`). 

## Principios aplicados
- **SOLID:** Clases con responsabilidades claras. 

- **SRP (Responsabilidad Única):**  
  Cada clase tiene una responsabilidad clara.  
  - `curso` gestiona código, nombre y horario.  
  - `pregrado` añade créditos, intensidad y nota mínima.  
  Esto evita mezclar lógica y mantiene el código modular.

- **OCP (Abierto/Cerrado):**  
  El sistema está abierto a extensión pero cerrado a modificación.  
  - Puedes crear nuevas clases como `posgrado` sin alterar `curso`.  
  - Esto permite escalar el proyecto sin romper lo existente.

- **LSP (Sustitución de Liskov):**  
  `pregrado` hereda de `curso` y puede usarse donde se espere un `curso`.  
  - Ejemplo: una lista de cursos puede contener tanto `curso` como `pregrado`.

- **ISP (Segregación de Interfaces):**  
  Aunque no se usan interfaces explícitas, las clases no tienen métodos innecesarios.  
  - Cada clase expone solo lo que necesita, evitando dependencias forzadas.

- **DIP (Inversión de Dependencias):**  
  El `programa` depende de abstracciones (`curso` y `pregrado`) y no de detalles internos.  
  - Esto facilita que el código pueda evolucionar hacia interfaces en el futuro.
 
 **KISS:** Código simple y directo, fácil de entender.  
- **YAGNI:** Solo se implementan los atributos necesarios para el ejercicio, evitando complejidad innecesaria.  
  
## Contenido del proyecto
Ejercicio | Clase/Archivo | Descripción
Instituto | curso.cs, pregrado.cs, programa.cs | Registro de cursos y créditos académicos.

## Estructura del proyecto
```text
arreglosCSharp/
├── src/
│   └── ejercicio01Instituto/
└── README.md

## Ejemplo de ejecución
Entrada:
Código: 300
Materia: matematicas
Horario: martes 10:00 am - 11:00 am
Créditos Académicos: 3
Intensidad Horaria Semanal: 3
Nota Aprobatoria: 4,5

Código

Salida:
InformacionCurso:
Código: 300
Nombre: matematicas
Horario: martes 10:00 am - 11:00 am
Informacion Pregrado:
Créditos Académicos: 3
Intensidad Horaria: 3
Nota Aprobatoria: 4,5


## Autor
Cristian Alexis Lucio Narváez  
Proyecto académico y portafolio profesional en C#.