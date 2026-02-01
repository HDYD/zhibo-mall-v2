const mock = {
  // 商城首页数据
  mallHome: {
    banners: ['/static/banner1.png', '/static/banner2.png'],
    categories: [
      { id: 1, name: '限时秒杀', icon: 'lightning-circle' },
      { id: 2, name: '领券中心', icon: 'ticket' },
      { id: 3, name: '商学院', icon: 'education' },
      { id: 4, name: '我的收藏', icon: 'star' },
      { id: 5, name: '物流信息', icon: 'truck' },
      { id: 6, name: '签到有礼', icon: 'calendar' },
      { id: 7, name: '今日爆款', icon: 'fire' },
      { id: 8, name: '联系客服', icon: 'service' },
    ],
    seckill: [
      { id: 101, name: '瑞士多功能军刀', price: 99.00, originalPrice: 299.00, image: '/static/logo.png' },
      { id: 102, name: '智能运动手环', price: 199.00, originalPrice: 499.00, image: '/static/logo.png' },
      { id: 103, name: '无线蓝牙耳机', price: 59.00, originalPrice: 159.00, image: '/static/logo.png' },
    ],
    products: [
      { id: 201, name: '高端定制商务西装外套', price: 1299.00, sales: 500, image: '/static/logo.png', tag: '热销' },
      { id: 202, name: '纯棉舒适透气T恤', price: 99.00, sales: 2000, image: '/static/logo.png', tag: '新品' },
      { id: 203, name: '复古真皮单肩包', price: 459.00, sales: 120, image: '/static/logo.png', tag: '' },
      { id: 204, name: '时尚潮流运动鞋', price: 399.00, sales: 880, image: '/static/logo.png', tag: '推荐' },
    ]
  },
  user: {
    userInfo: { nickname: '微信用户', avatar: '/static/logo.png', level: '黄金会员', id: '888888' },
    stats: { balance: 1280.50, points: 5600, coupons: 12 },
    orders: { pendingPay: 2, pendingShip: 1, pendingReceive: 0, afterSale: 0 }
  },
  livestreams: [
    { id: 301, title: '新品首发！超低价秒杀', host: '小雅好物', viewers: 12034, cover: '/static/logo.png', status: 'Live' },
    { id: 302, title: '深夜食堂：美味零食专场', host: '吃货大本营', viewers: 8900, cover: '/static/logo.png', status: 'Live' },
    { id: 303, title: '护肤美妆教学', host: '美妆达人', viewers: 4500, cover: '/static/logo.png', status: 'Upcoming' },
  ],
  courses: [
    { id: 401, title: '如何通过直播月入过万', instructor: '金牌讲师', price: 99.00, learners: 1200, cover: '/static/logo.png' },
    { id: 402, title: '短视频剪辑速成班', instructor: '剪辑大师', price: 199.00, learners: 850, cover: '/static/logo.png' },
    { id: 403, title: '私域流量运营实战', instructor: '运营总监', price: 299.00, learners: 500, cover: '/static/logo.png' },
  ],
  couponList: [
    { id: 1, value: 10, condition: '满100可用', name: '新人专享券', date: '2023-12-31', status: 0 },
    { id: 2, value: 50, condition: '满500可用', name: '大额满减券', date: '2023-11-30', status: 0 },
  ]
}

export default mock;
