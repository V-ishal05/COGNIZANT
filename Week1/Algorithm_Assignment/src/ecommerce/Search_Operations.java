package ecommerce;

public class Search_Operations {

    public static Product linearSearch(Product[] productList, String searchKey) {

        for (Product record : productList) {
            if (record.itemTitle.equalsIgnoreCase(searchKey)) {
                return record;
            }
        }

        return null;
    }

    public static Product binarySearch(Product[] productList, String searchKey) {

        int start = 0;
        int end = productList.length - 1;

        while (start <= end) {

            int middle = (start + end) / 2;

            int comparison =
                    productList[middle].itemTitle.compareToIgnoreCase(searchKey);

            if (comparison == 0) {
                return productList[middle];
            }

            if (comparison < 0) {
                start = middle + 1;
            } else {
                end = middle - 1;
            }
        }

        return null;
    }
}