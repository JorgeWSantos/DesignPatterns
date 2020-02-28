# Abstract Factory

### **Intenção**:
* fornecer uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas

### **Participantes**:

* **Abstract Factory:** declara uma interface para operações que criam objetos-produtos abstratos.
* **Concrete Factory:** implementa as operações que criam objetos-produtos concretos.
* **Abstract Product:** declara uma interface para um tipo de objeto-produto.
* **Concrete Product:** define um objeto-produto a ser criado pela correspondente fábrica concreta. Implementa a interface de Abstract Product.
* **Client:** usa somente as interfaces declaradas pelas classes Abstract Factory e Abstract Product.

### **Quando usar**:

### **Arquivos**
* DbCommand.cs
* DbConnection.cs
* DbFactory.cs
* data/sqlserver/SqlServerConnection.cs
* data/sqlserver/SqlServerCommands.cs
* data/sqlserver/SqlServerFactory.cs

#### Diagrama:
 ![](assets/abstract.png)
 
 Fonte: https://code4coders.files.wordpress.com/2016/04/abstract.gif?w=700
