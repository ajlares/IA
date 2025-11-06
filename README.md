# AI  
- Repositorio de todo lo visto en la clase de Inteligencia Artificial impartida por [Ion Lara](https://github.com/IonLara)  

## Carpetas en el main del proyecto:
- abandon_hope  
- class_activities  
- Hell  
- protate_exam_1  
- prostate_exam_2  

## [prostate_exam_2](https://github.com/ajlares/IA/tree/main/Assets/prostate_exam_2)  
En este apartado del proyecto se realizó el segundo examen parcial de la materia, en el cual se llevó a cabo la comparación de dos métodos para implementar inteligencias artificiales.  
Ambas IAs simulan un slime que limpia suciedad utilizando los siguientes parámetros:
- Una casa o base para recargarse de energía  
- Una lista de todas las suciedades existentes  
- NavMesh interno de Unity  

En ambos casos, el slime va a la casa a recargarse de energía, luego se dirige a la suciedad, la limpia y regresa a la casa para recargarse nuevamente.

### [Primer método](https://github.com/ajlares/IA/tree/main/Assets/prostate_exam_2/stateMachine):  
- Se implementó una máquina de estados utilizando Scriptable Objects.  

### [Segundo método](https://github.com/ajlares/IA/tree/main/Assets/prostate_exam_2/behabeourTree):  
- Se construyó un árbol de decisiones a partir de nodos.  

![Imagen comparativa de ambas IAs](https://github.com/ajlares/IA/blob/main/githubImages/Captura%20de%20pantalla%202025-11-06%20013427.png)

### Análisis de los métodos usados:  
Al ser ambas IAs relativamente sencillas, se pueden observar las bases y el alcance de cada una. Aun así, se aprecian diferencias notables entre ellas, de las cuales destaco las siguientes:

#### Máquinas de estados
- Simplicidad  
- Control sencillo del flujo  
- Fácil de visualizar  

#### Árboles de decisión
- Al depender tanto de ramas como de condiciones, es mejor para casos con muchas variables  
- Tiene mejor escalabilidad  
- Permite transiciones menos estáticas  

### Problemas en el desarrollo  
- En este caso, diría que no se presentó ningún problema significativo más allá del reto de adaptarse a un tema nuevo.  

### Preferencia en este caso concreto  
- Me quedo con el árbol de decisiones, ya que me parece más dinámico y con mayor potencial de escalabilidad. Además, al estar acostumbrado al uso de árboles, me resultó fácil visualizar el movimiento del slime a través de los nodos.
