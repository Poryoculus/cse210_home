# W04 Team Activity - Online Ordering

Each order will contain a list of products, containing the proper information. As well as a a customer object which inherits an address object. 

# Class: Order
## Attributes:
- List<Prodcut>
- Obj - Customer

## Constructor:
 - Add Products
 - Attach Customer


## Behaviors:
- CalculateTotalCost()
- GetPackingLabel()
- GetShippingLabel()


# Class: Product
## Attributes:
- _name: string
- _productID: string
- _productPrice: double
- _productQuantity: int

## Constructor:
Creates Product

## Behaviors:
- GetTotalCost()


# Class: Customer
## Attributes:
- _name: string
- _address: Address()

## Constructor:
- Create Customer

## Behaviors:
- livesInUSA(): bool



# Class: Address
## Attributes:
- _streetAddress: string
- _city: string
- _state: string
- _country: string

## Constructor:
- Build Address

## Behaviors:
- GetAddress(): string
- livesInUSA(): bool

