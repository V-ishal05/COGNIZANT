package factory;

public class FactoryTest {

    public static void main(String[] args) {

        DocumentFactory factory = new PdfFactory();

        Document document = factory.createDocument();

        document.open();
    }
}