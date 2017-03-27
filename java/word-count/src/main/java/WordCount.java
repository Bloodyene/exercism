
import java.util.HashMap;

public class WordCount {
    public HashMap<String, Integer> phrase(String text)
    {
        HashMap<String, Integer> m = new HashMap<String, Integer>();
        String lowerText = text.toLowerCase();
        int startIndex = -1;
        int endIndex = -1;
        for (int i = 0; i < lowerText.length(); i++) {
            if (Character.isLetterOrDigit(lowerText.charAt(i)) && startIndex < 0) {
                startIndex = i;
            }
            if (!Character.isLetterOrDigit(lowerText.charAt(i)) && startIndex >= 0) {
                endIndex = i;
            }
            if (i == lowerText.length()-1) {
                endIndex = i + 1;
            }
            if (startIndex >= 0 && endIndex >= 0) {
                String sub = lowerText.substring(startIndex, endIndex);
                if (m.containsKey(sub)) {
                    m.put(sub, m.get(sub) + 1);
                }
                else {
                    m.put(sub, 1);
                }
                
                startIndex = -1;
                endIndex = -1;
            }
        }
        return m;
    }
}
