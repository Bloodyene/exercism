import java.util.List;
import java.util.Map;
import java.util.HashMap;

public class Etl {
   public Map<String, Integer> transform(Map<Integer, List<String>> old) {
       Map<String, Integer> m = new HashMap();
       for (int key : old.keySet()) {
           for (String get : old.get(key)) {
               m.put(get.toLowerCase(), key);
           }
       }
      return m;
   }
}
