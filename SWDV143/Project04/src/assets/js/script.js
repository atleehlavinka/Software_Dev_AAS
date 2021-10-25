const App = {
  data() {
    return {
      displayCart: false,
      displayLabels: true,
      cart: [],
      products : [
        {
          "id": "001",
          "name": "Insulated Boots",
          "description": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
          "price": "45",
          "image_title": "slicker-jacket_lynda_29941",
          "image": "images/slide1.jpg"
        },
        {
          "id": "101",
          "name": "Backpacking Tent",
          "description": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
          "price": "99",
          "image": "images/slide2.jpg"
        },
        {
          "id": "201",
          "name": "Backpacking Backpack",
          "description": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
          "price": "120",
          "image": "images/slide3.jpg"
        },
        {
          "id": "301",
          "name": "Basic Compass",
          "description": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
          "price": "20",
          "image": "images/slide4.jpg"
        }
      ]
    }
  },
  computed: {
    filteredProducts() {
      return this.products.filter(item => (item.price))
    },
    cartTotal() {
      return this.cart.reduce((inc, item) => Number(item.price) + inc, 0)
    }
  },
  methods: {
    addToCart(product) {
      this.cart.push(product)
    },
    currency(value) {
      return `$${Number.parseFloat(value).toFixed(2)}`
    }
  }
}

Vue.createApp(App).mount('#app')