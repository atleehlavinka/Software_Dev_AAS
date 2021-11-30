<template>
<span class="ml-3 text-white">{{ dollar(amt)}}</span>
</template>

<script>
export default {
    props: ['amt'],
    methods: {
        dollar(value) {
            return '$' + Number.parseFloat(value).toFixed(2)
        }
    }
}
</script>