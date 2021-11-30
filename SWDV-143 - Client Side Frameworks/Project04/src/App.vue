<template>
  <div class="app">

    <headernav></headernav>

    <router-view />

    <footernav></footernav>

  </div>
</template>

<script>
import HeaderNav from './components/HeaderNav.vue'
import FooterNav from './components/FooterNav.vue'

export default {
  components: {
    'headernav' : HeaderNav,
    'footernav' : FooterNav,
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}

#app {
    background: url('./media/home-img3.jpg');
    background-position: center;
    background-size: cover;
}
</style>

<style src="./assets/css/bootstrap.min.css"></style>
<style src="./assets/css/style.css"></style>
<style src="./assets/css/all.css"></style>

