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

    public class BankCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Card number
        /// </summary>
        [JsonProperty("CardNo")]
        public string CardNo{ get; set; }

        /// <summary>
        /// Bank information
        /// </summary>
        [JsonProperty("BankInfo")]
        public string BankInfo{ get; set; }

        /// <summary>
        /// Expiration date. Format: 07/2023
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// Card type
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// Card name
        /// </summary>
        [JsonProperty("CardName")]
        public string CardName{ get; set; }

        /// <summary>
        /// Sliced image data
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BorderCutImage")]
        public string BorderCutImage{ get; set; }

        /// <summary>
        /// Card number image data
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CardNoImage")]
        public string CardNoImage{ get; set; }

        /// <summary>
        /// Warning code:
        /// -9110: the bank card date is invalid. 
        /// -9111: the bank card border is incomplete. 
        /// -9112: the bank card image is reflective.
        /// -9113: the bank card image is a photocopy.
        /// -9114: the bank card image is a photograph.
        /// Multiple warning codes may be returned at a time.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WarningCode")]
        public long?[] WarningCode{ get; set; }

        /// <summary>
        /// Image quality value, which is returned when `EnableQualityValue` is set to `true`. The smaller the value, the less clear the image is. Value range: 0−100 (a threshold greater than or equal to 50 is recommended.)
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityValue")]
        public long? QualityValue{ get; set; }

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
            this.SetParamSimple(map, prefix + "CardNo", this.CardNo);
            this.SetParamSimple(map, prefix + "BankInfo", this.BankInfo);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "CardName", this.CardName);
            this.SetParamSimple(map, prefix + "BorderCutImage", this.BorderCutImage);
            this.SetParamSimple(map, prefix + "CardNoImage", this.CardNoImage);
            this.SetParamArraySimple(map, prefix + "WarningCode.", this.WarningCode);
            this.SetParamSimple(map, prefix + "QualityValue", this.QualityValue);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

