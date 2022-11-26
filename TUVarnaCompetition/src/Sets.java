import java.math.BigInteger;
import java.util.Arrays;
import java.util.Scanner;

public class Sets {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int testsCount = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < testsCount; i++) {
            int[] numArray = Arrays.stream(scanner.nextLine().split(" "))
                    .mapToInt(Integer::parseInt)
                    .toArray();
            int p = numArray[0];
            int b = numArray[1];
            int x = numArray[2];
            int y = numArray[3];

            BigInteger productCombinations = (findFactorial(x, p)).divide(findFactorial(x-p, 1));
            BigInteger paperCombinations = (findFactorial(y, b)).divide(findFactorial(y-b, 1));

            BigInteger result = productCombinations.multiply(paperCombinations);
            System.out.println(result);
        }
    }
    public static BigInteger findFactorial(int n, int k) {
        BigInteger result = new BigInteger(String.valueOf(1));
        for (int i = n; i > k; i--) {
            result = result.multiply(BigInteger.valueOf(i));
        }
        return result;
    }
}
