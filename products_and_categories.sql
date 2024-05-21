-- Созание таблицы продуктов
create table dbo.products
(
	 product_id int not null
	,descr varchar(200) not null
	,constraint PK_products primary key (product_id) 
	,constraint FK_products foreign key (product_id) references products(product_id)
)

-- создание таблицы категорий
create table dbo.categories
(
	 category_id int not null
	,descr varchar(200) not null
	,constraint PK_categories primary key (category_id) 
	,constraint FK_categories foreign key (category_id) references categories(category_id)
)
go

-- создание промежуточной таблицы для 
create table dbo.products_and_categories
(
	 product_id int not null
	,category_id int not null
	,constraint PK_products_and_categories primary key (product_id, category_id) 
)

-- сам запрос
select products.descr, categories.descr
from products
left join products_and_categories on products_and_categories.product_id = products.product_id
left join categories on products_and_categories.category_id = categories.category_id