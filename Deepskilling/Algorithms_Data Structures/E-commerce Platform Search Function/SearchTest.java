public class SearchTest {

    // Linear Search
    public static Product linearSearch(Product[] products, int id) {

        for (Product p : products) {
            if (p.productId == id)
                return p;
        }

        return null;
    }

    // Binary Search
    public static Product binarySearch(Product[] products, int id) {

        int low = 0;
        int high = products.length - 1;

        while (low <= high) {

            int mid = (low + high) / 2;

            if (products[mid].productId == id)
                return products[mid];

            else if (products[mid].productId < id)
                low = mid + 1;

            else
                high = mid - 1;
        }

        return null;
    }

    public static void main(String[] args) {

        Product[] products = {

                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mobile", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Bag", "Fashion")

        };

        int searchId = 104;

        Product result1 = linearSearch(products, searchId);

        if (result1 != null)
            System.out.println("Linear Search Found: " + result1.productName);
        else
            System.out.println("Product Not Found");

        Product result2 = binarySearch(products, searchId);

        if (result2 != null)
            System.out.println("Binary Search Found: " + result2.productName);
        else
            System.out.println("Product Not Found");
    }
}