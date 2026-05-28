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

    public class BrazilRNMInfo : AbstractModel
    {
        
        /// <summary>
        /// SOBRENOME Type
        /// </summary>
        [JsonProperty("SOBRENOME")]
        public string SOBRENOME{ get; set; }

        /// <summary>
        /// NOME Type
        /// </summary>
        [JsonProperty("NOME")]
        public string NOME{ get; set; }

        /// <summary>
        /// DATA DE NASCIMENTO
        /// </summary>
        [JsonProperty("DATADENASCIMENTO")]
        public string DATADENASCIMENTO{ get; set; }

        /// <summary>
        /// SEXO F
        /// </summary>
        [JsonProperty("SEXO")]
        public string SEXO{ get; set; }

        /// <summary>
        /// FILIAÇÃO(MEMBERSHIP)
        /// </summary>
        [JsonProperty("MEMBERSHIP")]
        public string MEMBERSHIP{ get; set; }

        /// <summary>
        /// NACIONALIDADE Type
        /// </summary>
        [JsonProperty("NACIONALIDADE")]
        public string NACIONALIDADE{ get; set; }

        /// <summary>
        /// VALIDADE Type
        /// </summary>
        [JsonProperty("VALIDADE")]
        public string VALIDADE{ get; set; }

        /// <summary>
        /// RNM Type
        /// </summary>
        [JsonProperty("RNM")]
        public string RNM{ get; set; }

        /// <summary>
        /// CPF Type
        /// </summary>
        [JsonProperty("CPF")]
        public string CPF{ get; set; }

        /// <summary>
        /// CLASSIFICAÇÃO(CLASSIFICATION)
        /// </summary>
        [JsonProperty("CLASSIFICATION")]
        public string CLASSIFICATION{ get; set; }

        /// <summary>
        /// PRAZO DE RESIDENCIA
        /// </summary>
        [JsonProperty("PRAZODERESIDENCIA")]
        public string PRAZODERESIDENCIA{ get; set; }

        /// <summary>
        /// EMISSÃO(ISSUANCE)
        /// </summary>
        [JsonProperty("ISSUANCE")]
        public string ISSUANCE{ get; set; }

        /// <summary>
        /// AMPARO LEGAL(LegalHelp)
        /// </summary>
        [JsonProperty("AMPAROLEGAL")]
        public string AMPAROLEGAL{ get; set; }

        /// <summary>
        /// MRZCode
        /// </summary>
        [JsonProperty("MRZ")]
        public string MRZ{ get; set; }

        /// <summary>
        /// Portrait Image
        /// </summary>
        [JsonProperty("PortraitImage")]
        public string PortraitImage{ get; set; }

        /// <summary>
        /// PortraitImage(Back)
        /// </summary>
        [JsonProperty("PortraitImageBack")]
        public string PortraitImageBack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SOBRENOME", this.SOBRENOME);
            this.SetParamSimple(map, prefix + "NOME", this.NOME);
            this.SetParamSimple(map, prefix + "DATADENASCIMENTO", this.DATADENASCIMENTO);
            this.SetParamSimple(map, prefix + "SEXO", this.SEXO);
            this.SetParamSimple(map, prefix + "MEMBERSHIP", this.MEMBERSHIP);
            this.SetParamSimple(map, prefix + "NACIONALIDADE", this.NACIONALIDADE);
            this.SetParamSimple(map, prefix + "VALIDADE", this.VALIDADE);
            this.SetParamSimple(map, prefix + "RNM", this.RNM);
            this.SetParamSimple(map, prefix + "CPF", this.CPF);
            this.SetParamSimple(map, prefix + "CLASSIFICATION", this.CLASSIFICATION);
            this.SetParamSimple(map, prefix + "PRAZODERESIDENCIA", this.PRAZODERESIDENCIA);
            this.SetParamSimple(map, prefix + "ISSUANCE", this.ISSUANCE);
            this.SetParamSimple(map, prefix + "AMPAROLEGAL", this.AMPAROLEGAL);
            this.SetParamSimple(map, prefix + "MRZ", this.MRZ);
            this.SetParamSimple(map, prefix + "PortraitImage", this.PortraitImage);
            this.SetParamSimple(map, prefix + "PortraitImageBack", this.PortraitImageBack);
        }
    }
}

