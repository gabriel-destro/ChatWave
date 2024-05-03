<template>
    <div class="q-pa-md row justify-center">
        <div style="width: 100%; max-height: 400px;">
            <div style="width: 100%;" v-for="(message, index) in messages" :key="index">
                <div v-if="message.name === userActual">
                    <q-chat-message
                        :name="message.name"
                        avatar="https://cdn.quasar.dev/img/avatar4.jpg"
                        :text="[message.body]"
                        sent
                        :stamp="message.date"
                    />
                </div>
                <q-chat-message v-else
                    :name="message.name"
                    avatar="https://cdn.quasar.dev/img/avatar3.jpg"
                    :text="[message.body]"
                    :stamp="message.date"
                />
            </div>
        </div>
    </div>
  </template>
  
  <style>
  </style>
  
  <script>
  export default {
    name: 'ChatComponent',
    props: {
        userActual: String,
        messages: Array,
    }
  }
  </script>
  