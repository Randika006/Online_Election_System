package com.example.myvote;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class vote extends AppCompatActivity {


    RadioGroup radioGroup;
    RadioButton radioButton;
    TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_vote);
        radioGroup=findViewById(R.id.radioGroup);
        textView=findViewById(R.id.textView18);
        Button buttonApply=findViewById(R.id.button);


        Button butt1 = (Button) findViewById(R.id.btnvout);
        butt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int1 = new Intent(vote.this, MainActivity.class);
                startActivity(int1);


            }
        });

        buttonApply.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int radioId=radioGroup.getCheckedRadioButtonId();
                radioButton=findViewById( radioId);
                textView.setText("Your Choise:"+radioButton.getText());




            }
        });



    }
    public void onRadioButtonClicked(View view)
    {
      int radioId=radioGroup.getCheckedRadioButtonId();
      radioButton=findViewById( radioId);
        Toast.makeText(this,"Select Your Vote is a:"+radioButton.getText(),Toast.LENGTH_SHORT).show();


    }



}
