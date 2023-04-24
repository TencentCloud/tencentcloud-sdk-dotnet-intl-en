/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeIndonesiaIDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// The Single Identity Number.
        /// </summary>
        [JsonProperty("NIK")]
        public string NIK{ get; set; }

        /// <summary>
        /// The full name.
        /// </summary>
        [JsonProperty("Nama")]
        public string Nama{ get; set; }

        /// <summary>
        /// The place and date of birth.
        /// </summary>
        [JsonProperty("TempatTglLahir")]
        public string TempatTglLahir{ get; set; }

        /// <summary>
        /// The gender.
        /// </summary>
        [JsonProperty("JenisKelamin")]
        public string JenisKelamin{ get; set; }

        /// <summary>
        /// The blood type.
        /// </summary>
        [JsonProperty("GolDarah")]
        public string GolDarah{ get; set; }

        /// <summary>
        /// The address.
        /// </summary>
        [JsonProperty("Alamat")]
        public string Alamat{ get; set; }

        /// <summary>
        /// The street.
        /// </summary>
        [JsonProperty("RTRW")]
        public string RTRW{ get; set; }

        /// <summary>
        /// The village.
        /// </summary>
        [JsonProperty("KelDesa")]
        public string KelDesa{ get; set; }

        /// <summary>
        /// The region.
        /// </summary>
        [JsonProperty("Kecamatan")]
        public string Kecamatan{ get; set; }

        /// <summary>
        /// The religion.
        /// </summary>
        [JsonProperty("Agama")]
        public string Agama{ get; set; }

        /// <summary>
        /// The marital status.
        /// </summary>
        [JsonProperty("StatusPerkawinan")]
        public string StatusPerkawinan{ get; set; }

        /// <summary>
        /// The occupation.
        /// </summary>
        [JsonProperty("Perkerjaan")]
        public string Perkerjaan{ get; set; }

        /// <summary>
        /// The nationality.
        /// </summary>
        [JsonProperty("KewargaNegaraan")]
        public string KewargaNegaraan{ get; set; }

        /// <summary>
        /// The expiry date.
        /// </summary>
        [JsonProperty("BerlakuHingga")]
        public string BerlakuHingga{ get; set; }

        /// <summary>
        /// The issue date.
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate{ get; set; }

        /// <summary>
        /// The photo.
        /// </summary>
        [JsonProperty("Photo")]
        public string Photo{ get; set; }

        /// <summary>
        /// The province, which is supported when the value of `Scene` is `V2`.
        /// </summary>
        [JsonProperty("Provinsi")]
        public string Provinsi{ get; set; }

        /// <summary>
        /// The city, which is supported when the value of `Scene` is `V2`.
        /// </summary>
        [JsonProperty("Kota")]
        public string Kota{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


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
            this.SetParamSimple(map, prefix + "Photo", this.Photo);
            this.SetParamSimple(map, prefix + "Provinsi", this.Provinsi);
            this.SetParamSimple(map, prefix + "Kota", this.Kota);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

