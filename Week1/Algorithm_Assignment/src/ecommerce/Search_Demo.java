package ecommerce;

public class Search_Demo {

    public static void main(String[] args) {

        Product[] products = {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mobile", "Electronics"),
                new Product(103, "Mouse", "Accessories"),
                new Product(104, "Tablet", "Electronics"),
                new Product(105, "Watch", "Accessories")
        };

        Product linearResult =
                Search_Operations.linearSearch(products, "Mouse");

        if (linearResult != null) {
            System.out.println("Linear Search Found: "
                    + linearResult.itemTitle);
        }

        Product binaryResult =
                Search_Operations.binarySearch(products, "Mouse");

        if (binaryResult != null) {
            System.out.println("Binary Search Found: "
                    + binaryResult.itemTitle);
        }
    }
}