/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndonesiaIDCard : AbstractModel
    {
        
        /// <summary>
        /// License number
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NIK")]
        public string NIK{ get; set; }

        /// <summary>
        /// Name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nama")]
        public string Nama{ get; set; }

        /// <summary>
        /// Birth place/Birthday
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TempatTglLahir")]
        public string TempatTglLahir{ get; set; }

        /// <summary>
        /// Gender
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JenisKelamin")]
        public string JenisKelamin{ get; set; }

        /// <summary>
        /// Blood type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GolDarah")]
        public string GolDarah{ get; set; }

        /// <summary>
        /// Address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Alamat")]
        public string Alamat{ get; set; }

        /// <summary>
        /// Street
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RTRW")]
        public string RTRW{ get; set; }

        /// <summary>
        /// Village
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KelDesa")]
        public string KelDesa{ get; set; }

        /// <summary>
        /// Region
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Kecamatan")]
        public string Kecamatan{ get; set; }

        /// <summary>
        /// Religious beliefs
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Agama")]
        public string Agama{ get; set; }

        /// <summary>
        /// Marital status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusPerkawinan")]
        public string StatusPerkawinan{ get; set; }

        /// <summary>
        /// Job
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Perkerjaan")]
        public string Perkerjaan{ get; set; }

        /// <summary>
        /// Nationality
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KewargaNegaraan")]
        public string KewargaNegaraan{ get; set; }

        /// <summary>
        /// ID card validity period
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BerlakuHingga")]
        public string BerlakuHingga{ get; set; }

        /// <summary>
        /// Date of issue
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate{ get; set; }

        /// <summary>
        /// Province
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Provinsi")]
        public string Provinsi{ get; set; }

        /// <summary>
        /// City
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Kota")]
        public string Kota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NIK", this.NIK);
            this.SetParamSimple(map, prefix + "Nama", this.Nama);
            this.SetParamSimple(map, prefix + "TempatTglLahir", this.TempatTglLahir);
            this.SetParamSimple(map, prefix + "JenisKelamin", this.JenisKelamin);
            this.SetParamSimple(map, prefix + "GolDarah", this.GolDarah);
            this.SetParamSimple(map, prefix + "Alamat", this.Alamat);
            this.SetParamSimple(map, prefix + "RTRW", this.RTRW);
            this.SetParamSimple(map, prefix + "KelDesa", this.KelDesa);
            this.SetParamSimple(map, prefix + "Kecamatan", this.Kecamatan);
            this.SetParamSimple(map, prefix + "Agama", this.Agama);
            this.SetParamSimple(map, prefix + "StatusPerkawinan", this.StatusPerkawinan);
            this.SetParamSimple(map, prefix + "Perkerjaan", this.Perkerjaan);
            this.SetParamSimple(map, prefix + "KewargaNegaraan", this.KewargaNegaraan);
            this.SetParamSimple(map, prefix + "BerlakuHingga", this.BerlakuHingga);
            this.SetParamSimple(map, prefix + "IssuedDate", this.IssuedDate);
            this.SetParamSimple(map, prefix + "Provinsi", this.Provinsi);
            this.SetParamSimple(map, prefix + "Kota", this.Kota);
        }
    }
}

