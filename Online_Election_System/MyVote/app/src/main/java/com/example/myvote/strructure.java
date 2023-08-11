package com.example.myvote;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class strructure extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_strructure);
        Button butt1 = (Button) findViewById(R.id.btnoutp);
        Button butt2 = (Button) findViewById(R.id.btnns);
        butt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int1 = new Intent(strructure.this, MainActivity.class);
                startActivity(int1);


            }
        });

        butt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int2 = new Intent(strructure.this, sparliment.class);
                startActivity(int2);


            }
        });




    }
}
