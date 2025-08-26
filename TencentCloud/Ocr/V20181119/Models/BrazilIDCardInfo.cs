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

    public class BrazilIDCardInfo : AbstractModel
    {
        
        /// <summary>
        /// Name.
        /// </summary>
        [JsonProperty("Nome")]
        public string Nome{ get; set; }

        /// <summary>
        /// Parent information.
        /// </summary>
        [JsonProperty("MemberShip")]
        public string MemberShip{ get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonProperty("DataNascimento")]
        public string DataNascimento{ get; set; }

        /// <summary>
        /// Issuing organization.
        /// </summary>
        [JsonProperty("IssuingAgency")]
        public string IssuingAgency{ get; set; }

        /// <summary>
        /// Specifies the blood type.
        /// </summary>
        [JsonProperty("Fatorrh")]
        public string Fatorrh{ get; set; }

        /// <summary>
        /// Birthplace.
        /// </summary>
        [JsonProperty("NaturalIDade")]
        public string NaturalIDade{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Observations")]
        public string Observations{ get; set; }

        /// <summary>
        /// CPF Type
        /// </summary>
        [JsonProperty("CPF")]
        public string CPF{ get; set; }

        /// <summary>
        /// DNI Type
        /// </summary>
        [JsonProperty("DNI")]
        public string DNI{ get; set; }

        /// <summary>
        /// Common registration.
        /// </summary>
        [JsonProperty("RegistroGeral")]
        public string RegistroGeral{ get; set; }

        /// <summary>
        /// Issue date. valid values: dd/mm/yyyy.
        /// </summary>
        [JsonProperty("DispatchDate")]
        public string DispatchDate{ get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        [JsonProperty("Registro")]
        public string Registro{ get; set; }

        /// <summary>
        /// Specifies the avatar in Base64 format of the id card.
        /// </summary>
        [JsonProperty("PortraitImage")]
        public string PortraitImage{ get; set; }

        /// <summary>
        /// Original identity information.
        /// </summary>
        [JsonProperty("DocOrigem")]
        public string DocOrigem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Nome", this.Nome);
            this.SetParamSimple(map, prefix + "MemberShip", this.MemberShip);
            this.SetParamSimple(map, prefix + "DataNascimento", this.DataNascimento);
            this.SetParamSimple(map, prefix + "IssuingAgency", this.IssuingAgency);
            this.SetParamSimple(map, prefix + "Fatorrh", this.Fatorrh);
            this.SetParamSimple(map, prefix + "NaturalIDade", this.NaturalIDade);
            this.SetParamSimple(map, prefix + "Observations", this.Observations);
            this.SetParamSimple(map, prefix + "CPF", this.CPF);
            this.SetParamSimple(map, prefix + "DNI", this.DNI);
            this.SetParamSimple(map, prefix + "RegistroGeral", this.RegistroGeral);
            this.SetParamSimple(map, prefix + "DispatchDate", this.DispatchDate);
            this.SetParamSimple(map, prefix + "Registro", this.Registro);
            this.SetParamSimple(map, prefix + "PortraitImage", this.PortraitImage);
            this.SetParamSimple(map, prefix + "DocOrigem", this.DocOrigem);
        }
    }
}

