# OOP-Product-Catalogue


2) Introduction to OOP inheritance. 

	Points for this task - 5;
	Deadline for implementation and passing before points will be divided by 2 - Second midterm;
	Task details:

Using UML Class diagram defined below, need to implement required classes for store catalog with products. Each variant have different products. Each product must be inherited from base class with common fields. All information about fields and methods will be described in UML diagram.

Products catalog must be represented as collection of different products.

For products collection use generic List<T>. Think what type of T you need to use. Read about UpCast (Lecture 3).

 
Product types need to create based on derived product classes. For example, you have products: iron, toothbrush, air conditioning. For this products you need to create 2 types: HouseholdProducts and HealthAndBeauty
Catalog need to initialize in start of program (CI) (at least 3 different products by each derived product class).

Functionality for user:

View product catalog (VC);
Order catalog by price ascending and descending (OPAsc, OPDesc);
Order catalog by product type name ascending and descending (OTAsc, OTDesc);
Order catalog by Name ascending and descending (ONAsc, ONDesc)
Add product to cart (cart must be represented as another collection of products) (CAdd);
View cart with displaying total sum for all products and total product weight(VCart);




DETAILS:
        	For user input I recommend to use next keys bindings:
·          “Q” button – order by price ascending;
·         “W” button – order by price descending;
·         “E” button – order by type ascending;
·         “R” button – order by type descending;
      “Y” button – order by product name ascending;
·         “U” button – order by product name descending;
·         “C” button – view cart with total sum and weight;
	“K” - add product to cart:
		Numbers(1..N) – when you type number and press enter, product with same index need to add to cart;


	**I have completed the task using Variant 3

	UML Diagrams:
Variant 1: https://drive.google.com/file/d/1HfhRs3IA0GLTv3BOdgr2qa5hnyt4cIMl/view?usp=sharing

Variant 2:
https://drive.google.com/file/d/1v2qth0P4R5ZC5BGIlkdMo4ajqnyqKRlJ/view?usp=sharing

Variant 3:
https://drive.google.com/file/d/1L2ORqQG2aTc0yJKox8_y2GdmbLmE00x6/view?usp=sharing








