﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Box2DCS;

namespace Box2DCSAndroid
{
    [Activity(Label = "Box2DCSAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            CallBox2D();
        }

        private void CallBox2D()
        {
            b2Vec2 gravity = new b2Vec2(0.0f, -10.0f);

            b2World world = new b2World(gravity);

            b2BodyDef groundBodyDef = new b2BodyDef();
            groundBodyDef.position.Set(0.0f, -10.0f);

            b2Body groundBody = world.CreateBody(groundBodyDef);

            b2PolygonShape groundBox = new b2PolygonShape();
            groundBox.SetAsBox(50.0f, 10.0f);

            groundBody.CreateFixture(groundBox, 0.0f);

            b2BodyDef bodyDef = new b2BodyDef();
            bodyDef.type = b2BodyType.b2_dynamicBody;
            bodyDef.position.Set(0.0f, 4.0f);

            b2Body body = world.CreateBody(bodyDef);

            b2PolygonShape dynamicBox = new b2PolygonShape();
            dynamicBox.SetAsBox(1.0f, 1.0f);

            b2FixtureDef fixtureDef = new b2FixtureDef();
            fixtureDef.shape = dynamicBox;
            fixtureDef.density = 1.0f;
            fixtureDef.friction = 0.3f;
            body.CreateFixture(fixtureDef);

            float timeStep = 1.0f / 60.0f;
            int velocityIteration = 6;
            int positionIteration = 2;

            for (int i = 0; i < 60; ++i)
            {
                world.Step(timeStep, velocityIteration, positionIteration);

                b2Vec2 position = body.GetPosition();
                float angle = body.GetAngle();

                Console.WriteLine("{0} {1} {2}", String.Format("{0:F2}", position.x), String.Format("{0:F2}", position.y), String.Format("{0:F2}", angle));
            }

            Console.ReadLine();
        }
    }
}

