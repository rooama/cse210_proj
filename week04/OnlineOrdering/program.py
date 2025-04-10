class Address:
    def __init__(self, street, city, state, country):
        self.__street = street
        self.__city = city
        self.__state = state
        self.__country = country

    def is_in_usa(self):
        return self.__country.lower() == "usa"
    
    def get_full_address(self):
        return f"{self.__street}\n{self.__city}, {self.__state}\n{self.__country}"


class Customer:
    def __init__(self, name, address):
        self.__name = name
        self.__address = address
    
    def get_name(self):
        return self.__name
    
    def is_in_usa(self):
        return self.__address.is_in_usa()
    
    def get_address(self):
        return self.__address.get_full_address()


class Product:
    def __init__(self, name, product_id, price, quantity):
        self.__name = name
        self.__product_id = product_id
        self.__price = price
        self.__quantity = quantity
    
    def get_total_cost(self):
        return self.__price * self.__quantity
    
    def get_packing_info(self):
        return f"{self.__name} (ID: {self.__product_id})"


class Order:
    def __init__(self, customer):
        self.__customer = customer
        self.__products = []
    
    def add_product(self, product):
        self.__products.append(product)
    
    def get_total_price(self):
        total_cost = sum(product.get_total_cost() for product in self.__products)
        shipping_cost = 5 if self.__customer.is_in_usa() else 35
        return total_cost + shipping_cost
    
    def get_packing_label(self):
        return "\n".join(product.get_packing_info() for product in self.__products)
    
    def get_shipping_label(self):
        return f"{self.__customer.get_name()}\n{self.__customer.get_address()}"


# Example Usage:
address1 = Address("123 Main St", "New York", "NY", "USA")
customer1 = Customer("John Doe", address1)
order1 = Order(customer1)
order1.add_product(Product("Laptop", "A123", 1000, 1))
order1.add_product(Product("Mouse", "B456", 50, 2))

address2 = Address("456 Elm St", "Toronto", "ON", "Canada")
customer2 = Customer("Jane Smith", address2)
order2 = Order(customer2)
order2.add_product(Product("Keyboard", "C789", 80, 1))
order2.add_product(Product("Monitor", "D012", 300, 1))

# Displaying Results
print("Order 1 Packing Label:")
print(order1.get_packing_label())
print("\nOrder 1 Shipping Label:")
print(order1.get_shipping_label())
print(f"\nTotal Price: ${order1.get_total_price():.2f}\n")

print("Order 2 Packing Label:")
print(order2.get_packing_label())
print("\nOrder 2 Shipping Label:")
print(order2.get_shipping_label())
print(f"\nTotal Price: ${order2.get_total_price():.2f}")
