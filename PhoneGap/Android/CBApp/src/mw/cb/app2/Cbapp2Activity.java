package mw.cb.app2;

import org.apache.cordova.DroidGap;
import android.os.Bundle;

public class Cbapp2Activity extends DroidGap {
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        super.loadUrl("file:///android_asset/www/index.html");
    }
}