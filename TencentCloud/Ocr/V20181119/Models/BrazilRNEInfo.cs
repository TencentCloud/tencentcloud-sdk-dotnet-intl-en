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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BrazilRNEInfo : AbstractModel
    {
        
        /// <summary>
        /// RNE
        /// </summary>
        [JsonProperty("RNE")]
        public string RNE{ get; set; }

        /// <summary>
        /// CLASSIFICAÇÃO(CLASSIFICATION)
        /// </summary>
        [JsonProperty("CLASSIFICATION")]
        public string CLASSIFICATION{ get; set; }

        /// <summary>
        /// VALIDADE
        /// </summary>
        [JsonProperty("VALIDADE")]
        public string VALIDADE{ get; set; }

        /// <summary>
        /// NOME
        /// </summary>
        [JsonProperty("NOME")]
        public string NOME{ get; set; }

        /// <summary>
        /// FILIAÇÃO(MEMBERSHIP)
        /// </summary>
        [JsonProperty("Membership")]
        public string Membership{ get; set; }

        /// <summary>
        /// NACIONALIDADE
        /// </summary>
        [JsonProperty("NACIONALIDADE")]
        public string NACIONALIDADE{ get; set; }

        /// <summary>
        /// NATURALIDADE(PAÍS)
        /// </summary>
        [JsonProperty("NATURALIDADE")]
        public string NATURALIDADE{ get; set; }

        /// <summary>
        /// ORGÃO EXPEDIDOR(IssuingAgency)
        /// </summary>
        [JsonProperty("IssuingAgency")]
        public string IssuingAgency{ get; set; }

        /// <summary>
        /// DATA DE NASCIMENTO(DateOfBirth)
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// SEXO
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// DATA DE ENTRADA(EntryDate)
        /// </summary>
        [JsonProperty("EntryDate")]
        public string EntryDate{ get; set; }

        /// <summary>
        /// VIA
        /// </summary>
        [JsonProperty("VIA")]
        public string VIA{ get; set; }

        /// <summary>
        /// DATA DE EXPEDIÇÃO(DispatchDate)
        /// </summary>
        [JsonProperty("DispatchDate")]
        public string DispatchDate{ get; set; }

        /// <summary>
        /// MRZ
        /// </summary>
        [JsonProperty("MRZ")]
        public string MRZ{ get; set; }

        /// <summary>
        /// PortraitImage
        /// </summary>
        [JsonProperty("PortraitImage")]
        public string PortraitImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RNE", this.RNE);
            this.SetParamSimple(map, prefix + "CLASSIFICATION", this.CLASSIFICATION);
            this.SetParamSimple(map, prefix + "VALIDADE", this.VALIDADE);
            this.SetParamSimple(map, prefix + "NOME", this.NOME);
            this.SetParamSimple(map, prefix + "Membership", this.Membership);
            this.SetParamSimple(map, prefix + "NACIONALIDADE", this.NACIONALIDADE);
            this.SetParamSimple(map, prefix + "NATURALIDADE", this.NATURALIDADE);
            this.SetParamSimple(map, prefix + "IssuingAgency", this.IssuingAgency);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "EntryDate", this.EntryDate);
            this.SetParamSimple(map, prefix + "VIA", this.VIA);
            this.SetParamSimple(map, prefix + "DispatchDate", this.DispatchDate);
            this.SetParamSimple(map, prefix + "MRZ", this.MRZ);
            this.SetParamSimple(map, prefix + "PortraitImage", this.PortraitImage);
        }
    }
}

