﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3{
   class SalesCounter {

        private IEnumerable<Sale> _sales;
 
        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

      


        //List 2-15
        //売上げデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
            //List2-17
            //店舗別売上げを求める
           public IDictionary<string, int> GetPerStoreSales() {
                var dict = new Dictionary<string, int>();
                foreach (var sale in _sales) {
                    if (dict.ContainsKey(sale.ShopName))
                        //既にコレクションに店舗が設定されている
                        dict[sale.ShopName] += sale.Amount;
                    else
                        //コレクションへ店舗を登録
                        dict[sale.ShopName] = sale.Amount;

                }
                return dict;
            }
        //商品カテゴリ別売上げを求める
        public IDictionary<string, int> GetPerCategorySales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    //既にコレクションに店舗が設定されている
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ProductCategory] = sale.Amount;

            }
            return dict;
        }
    }
    }

