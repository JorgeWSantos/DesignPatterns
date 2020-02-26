# Composite pattern

### **Definição:**

* Compor objetos em estruturas de arvore para representar hierarquias parte ou todo.
Composite permite que clientes tratem objetos individuais e composição de objetos de maneira uniforme.

## Benefícios: 
* Fácil adição de componentes e facilita a iteração com hierarquias complexas.
* Torna o client simples.

### **Participantes:**
* **Component:** define a interface da para os objetos na composição, implementa comportamento padrao para a interface comum, declara interface para gerenciar filhos.

* **Leaf:** representa objetos "folha" na composição.

* **Composite:** define comportamentos para componentes que tem filhos; implementa operações relacionadas com os filhos.

* **Client:** Manipula objetos na composição através da interface de component.

<!-- ### **Quando Implementar:**

* quando houver necessidade que uma classe tem apenas uma instancia. -->

#### Diagrama:
 <!-- ![](assets/singleton.png)
 
 Fonte: https://reactiveprogramming.io/public/books/patterns/img/patterns-articles/singleton-diagram.png -->


