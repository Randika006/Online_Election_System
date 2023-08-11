package com.example.myvote;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button butt1 = (Button) findViewById(R.id.but1);
        Button butt2 = (Button) findViewById(R.id.but2);
        Button butt3 = (Button) findViewById(R.id.but4);
        Button butt4 = (Button) findViewById(R.id.but5);
        Button butt5 = (Button) findViewById(R.id.but3);
        Button butt6=(Button) findViewById(R.id.btn7);
        Button butt7=(Button) findViewById(R.id.btn6);

        butt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int1 = new Intent(MainActivity.this, login.class);
                startActivity(int1);


            }
        });
        butt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int2 = new Intent(MainActivity.this, register.class);
                startActivity(int2);


            }
        });

        butt3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int3 = new Intent(MainActivity.this, balet.class);
                startActivity(int3);


            }
        });
        butt4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int4 = new Intent(MainActivity.this, strructure.class);
                startActivity(int4);


            }
        });

        butt5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int5 = new Intent(MainActivity.this, candidates.class);
                startActivity(int5);


            }
        });

        butt6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int6 = new Intent(MainActivity.this, elmap.class);
                startActivity(int6);


            }
        });
        butt7.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int6 = new Intent(MainActivity.this, realeased.class);
                startActivity(int6);


            }
        });




    }
}
