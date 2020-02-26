# Adapter pattern

### **Definição:**

* Converte a interface de uma classe em outra interface esperada pelos clientes. Permite que classes trabalhem em conjunto, pois de outra forma não poderiam devido a terem interfaces incompativeis.

### **Participantes:**
* **Target:** define uma interface especifica do dominio que o client usa.

* **Client:** colabora com objetos compativeis com a interface Target.

* **Adaptee:** define uma interface existente que necessita ser adaptada.

* **Adapter:** adapta a interface do adaptee á interface do Target.

**Quando Implementar:**

* quando houver necessidade de adaptar um comportamento.

**benefícios:**
* Permite o uso comportamentos incompativeis através da classe adapter. 

### Diagrama:
![](assets/adapter.svg)
 
 Fonte: https://upload.wikimedia.org/wikipedia/commons/f/fd/Adapter_using_inheritance_UML_class_diagram.svg

