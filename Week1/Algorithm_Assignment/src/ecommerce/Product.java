package ecommerce;

public class Product {
    int itemCode;
    String itemTitle;
    String itemType;

    public Product(int itemCode, String itemTitle, String itemType) {
        this.itemCode = itemCode;
        this.itemTitle = itemTitle;
        this.itemType = itemType;
    }
}