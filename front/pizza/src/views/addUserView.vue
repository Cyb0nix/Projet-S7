
<template>
  <section class="max-w-4xl p-6 mx-auto bg-white rounded-md shadow-md my-24">
    <h2 class="text-lg font-semibold text-gray-700 capitalize ">Ajouter un client</h2>

    <form>
      <div class="grid grid-cols-1 gap-6 mt-4 sm:grid-cols-2">
        <div>
          <label class="text-gray-700 " for="surname">Nom</label>
          <input id="surname" v-model="newClient.surname" type="text" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>

        <div>
          <label class="text-gray-700 " for="firstname">Prénom</label>
          <input id="firstname" v-model="newClient.firstname" type="text" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md  focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>

        <div>
          <label class="text-gray-700 " for="addresse">Addresse</label>
          <input id="addresse" v-model="newClient.address" type="text" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md  focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>

        <div>
          <label class="text-gray-700 " for="telephone">Téléphone</label>
          <input id="telephone" v-model="newClient.telephone" type="tel" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md  focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>
      </div>

      <div class="flex justify-end mt-6">
        <button @click="addClient()" class="px-8 py-2.5 leading-5 text-white transition-colors duration-300 transform bg-gray-700 rounded-md hover:bg-gray-600 focus:outline-none focus:bg-gray-600">Ajouter</button>
      </div>
    </form>
  </section>
</template>

<script >

export default {
  name: "addUserView",
  data() {
    return {
      clients: [],
      newClient: {
        surname: "",
        firstname: "",
        telephone: "",
        address: "",
      },
    };
  },
  methods: {
    async addClient() {
      await fetch("http://localhost:5165/api/Customer", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(this.newClient),
      });
    },
  },
};

</script>

<style scoped>

</style>