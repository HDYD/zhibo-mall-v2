<template>
  <view class="cart-container">
    <view v-if="cartList.length === 0" class="empty-cart">
      <t-icon name="cart" size="64" color="#ccc" class="empty-icon" />
      <text class="empty-text">购物车还是空的，去逛逛吧~</text>
      <button class="go-shopping" @click="goShopping">去逛逛</button>
    </view>
    <view v-else>
      <view class="cart-list">
        <view class="cart-item" v-for="(item, index) in cartList" :key="index">
          <view class="checkbox" @click="toggleCheck(index)">
            <t-icon v-if="item.checked" name="check-circle-filled" size="24" color="#ff5722" />
            <t-icon v-else name="circle" size="24" color="#ccc" />
          </view>
          <image class="item-img" :src="item.image" mode="aspectFill" />
          <view class="item-info">
            <text class="item-name">{{ item.name }}</text>
            <view class="item-bottom">
              <text class="item-price">¥{{ item.price }}</text>
              <view class="counter">
                <view class="counter-btn" @click="changeQuantity(index, -1)"><t-icon name="remove" size="16" /></view>
                <text class="count">{{ item.quantity }}</text>
                <view class="counter-btn" @click="changeQuantity(index, 1)"><t-icon name="add" size="16" /></view>
              </view>
            </view>
          </view>
        </view>
      </view>
      <view class="cart-footer">
        <view class="footer-left">
          <view class="checkbox" @click="toggleAll">
            <t-icon v-if="isAllChecked" name="check-circle-filled" size="24" color="#ff5722" />
            <t-icon v-else name="circle" size="24" color="#ccc" />
          </view>
          <text class="all-text">全选</text>
        </view>
        <view class="footer-right">
          <text class="total-text">合计: <text class="total-price">¥{{ totalPrice }}</text></text>
          <button class="settle-btn" @click="settle">结算({{ checkedCount }})</button>
        </view>
      </view>
    </view>
  </view>
</template>

<script>
import mock from '@/common/mock.js'
export default {
  data() { return { cartList: JSON.parse(JSON.stringify(mock.cart)) } },
  computed: {
    checkedCount() { return this.cartList.filter(item => item.checked).length; },
    isAllChecked() { return this.cartList.length > 0 && this.cartList.every(item => item.checked); },
    totalPrice() { return this.cartList.filter(item => item.checked).reduce((sum, item) => sum + item.price * item.quantity, 0).toFixed(2); }
  },
  methods: {
    toggleCheck(index) { this.cartList[index].checked = !this.cartList[index].checked; },
    toggleAll() { const v = !this.isAllChecked; this.cartList.forEach(item => item.checked = v); },
    changeQuantity(index, delta) {
      const q = this.cartList[index].quantity + delta;
      if (q < 1) { uni.showModal({ title: '提示', content: '是否删除该商品?', success: (res) => { if (res.confirm) this.cartList.splice(index, 1); } }); }
      else { this.cartList[index].quantity = q; }
    },
    settle() { if (this.checkedCount === 0) { uni.showToast({ title: '请选择商品', icon: 'none' }); return; } uni.navigateTo({ url: '/pages/mall/order' }); },
    goShopping() { uni.switchTab({ url: '/pages/mall/index' }); }
  }
}
</script>

<style>
.cart-container { min-height: 100vh; background-color: #f5f5f5; padding-bottom: 60px; }
.empty-cart { display: flex; flex-direction: column; align-items: center; padding-top: 100px; }
.empty-text { font-size: 14px; color: #999; margin: 20px 0; }
.go-shopping { width: 150px; background-color: #ff5722; color: #fff; border-radius: 20px; }
.cart-list { padding: 10px; }
.cart-item { background-color: #fff; padding: 10px; margin-bottom: 10px; border-radius: 5px; display: flex; align-items: center; }
.checkbox { margin-right: 10px; }
.item-img { width: 80px; height: 80px; border-radius: 5px; margin-right: 10px; }
.item-info { flex: 1; display: flex; flex-direction: column; justify-content: space-between; height: 80px; }
.item-name { font-size: 14px; color: #333; }
.item-bottom { display: flex; justify-content: space-between; align-items: center; }
.item-price { color: #ff5722; font-weight: bold; font-size: 16px; }
.counter { display: flex; align-items: center; border: 1px solid #ddd; border-radius: 4px; }
.counter-btn { width: 24px; height: 24px; display: flex; align-items: center; justify-content: center; }
.count { width: 30px; text-align: center; font-size: 12px; border-left: 1px solid #ddd; border-right: 1px solid #ddd; line-height: 24px; }
.cart-footer { position: fixed; bottom: 0; left: 0; right: 0; height: 50px; background-color: #fff; display: flex; justify-content: space-between; align-items: center; padding: 0 15px; box-shadow: 0 -1px 5px rgba(0,0,0,0.1); }
.footer-left { display: flex; align-items: center; }
.all-text { margin-left: 5px; font-size: 14px; color: #666; }
.footer-right { display: flex; align-items: center; }
.total-text { font-size: 12px; margin-right: 10px; color: #333; }
.total-price { color: #ff5722; font-size: 16px; font-weight: bold; }
.settle-btn { background-color: #ff5722; color: #fff; padding: 0 20px; line-height: 35px; border-radius: 20px; border: none; font-size: 14px; }
</style>
