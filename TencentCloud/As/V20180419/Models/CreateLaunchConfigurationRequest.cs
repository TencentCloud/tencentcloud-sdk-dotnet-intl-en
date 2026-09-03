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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLaunchConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Display name of the launch configuration. The name only supports Chinese, English, numbers, underscores, the separator "-", and decimal points. The maximum length cannot exceed 60 bytes.</p>
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// <p>Specify a valid <a href="https://www.tencentcloud.com/document/product/213/4940?from_cn_redirect=1">image</a> ID, such as <code>img-8toqc6s3</code>. One and only one of image ID and image family name must be filled in. There are four image types:<br><li>Public image</li><li>Custom image</li><li>Shared image</li><li>Service market image</li><br>You can get available image IDs in the following ways:<br><li>You can query the image IDs of <code>public images</code>, <code>custom images</code>, and <code>shared images</code> by logging in to the <a href="https://console.cloud.tencent.com/cvm/image?rid=1&amp;imageType=PUBLIC_IMAGE">console</a>; query the image IDs in the <code>service image market</code> in <a href="https://market.cloud.tencent.com/list">Marketplace</a>.</li><li>Call the <a href="https://www.tencentcloud.com/document/api/213/15715?from_cn_redirect=1">DescribeImages</a> API and get the <code>ImageId</code> field in the returned information.</li></p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>The project ID of the launch configuration. Default value: 0, indicating the default project. Obtain this parameter by calling <a href="https://www.tencentcloud.com/document/api/651/78725?from_cn_redirect=1">DescribeProject</a> and using the projectId field in the return value.<br>Note: The project ID of instances within the scaling group is the scaling group project ID, irrelevant to the value here.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>Instance model. Different instance models specify different resource specifications. The specific values can be obtained by calling the <a href="https://www.tencentcloud.com/document/api/213/15749?from_cn_redirect=1">DescribeInstanceTypeConfigs</a> API to get the latest specification table or refer to the <a href="https://www.tencentcloud.com/document/product/213/11518?from_cn_redirect=1">instance type</a> description.<br>The <code>InstanceType</code> and <code>InstanceTypes</code> parameters are mutually exclusive, and one and only one must be filled in.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Instance system disk configuration information. If not specified, it will be allocated based on system default values.</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// <p>Instance data disk configuration information. If not specified, no data disks are purchased by default, and a maximum of 11 data disks can be specified.</p>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// <p>Public network bandwidth-related information settings. If not specified, the public network bandwidth defaults to 0 Mbps.</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>Instance login settings. Through this parameter, you can set the instance's login method to password, key, or maintain the image's original login settings. By default, a password will be randomly generated, and the user will be notified through an internal message.</p>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// <p>Security group to which an instance belongs. The value of this parameter can be obtained from the returned <code>SecurityGroupId</code> field of the <a href="https://www.tencentcloud.com/document/api/215/15808?from_cn_redirect=1">DescribeSecurityGroups</a> API. If this parameter is not specified, no security groups are associated by default.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>Enhancement services. This parameter can be used to specify whether to enable services such as Cloud Monitor and cloud security. If not specified, cloud monitoring and cloud security services are enabled by default.</p>
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// <p>Custom data after Base64 encoding should not exceed 16KB.</p>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// <p>Instance billing type. The default value of CVM is handled as POSTPAID_BY_HOUR.</p><li>POSTPAID_BY_HOUR: hourly postpaid</li><li>SPOTPAID: spot payment</li><li>PREPAID: prepayment, which is monthly subscription</li><li>CDCPAID: dedicated cluster payment</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Market options of the instance, such as spot instance parameters. This parameter is required if the payment mode of the specified instance is spot payment.</p>
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// <p>Instance model list. Different instance models specify different resource specifications, and a maximum of 10 instance models are supported.<br>The <code>InstanceType</code> and <code>InstanceTypes</code> parameters are mutually exclusive. One and only one of them must be filled in. To obtain the specific values, call the API <a href="https://www.tencentcloud.com/document/api/213/15749?from_cn_redirect=1">DescribeInstanceTypeConfigs</a> to get the latest specification table or see <a href="https://www.tencentcloud.com/document/product/213/11518?from_cn_redirect=1">Instance Specifications</a>.</p>
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// <p>CAM role name, which can be obtained from the roleName in the return value from the <a href="https://www.tencentcloud.com/document/product/598/36223?from_cn_redirect=1">DescribeRoleList</a> API.</p>
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// <p>Instance type validation policy. Valid values include ALL and ANY. Default value: ANY. This parameter is valid only when InstanceTypes contains multiple models.</p><li>ALL: Verification passes if all InstanceTypes are available; otherwise, a verification error will be reported.</li><li>ANY: Verification passes if any InstanceType is available; otherwise, a verification error will be reported.</li><p>Common causes of InstanceTypes unavailable include the instance type sold out and the corresponding cloud disk sold out.<br>If a model in InstanceTypes does not exist or has been removed, a verification error will be reported regardless of the value of InstanceTypesCheckPolicy.</p>
        /// </summary>
        [JsonProperty("InstanceTypesCheckPolicy")]
        public string InstanceTypesCheckPolicy{ get; set; }

        /// <summary>
        /// <p>Tag list. By specifying this parameter, the instances added through scale-out can be bound to the tag. A maximum of 10 tags can be specified.</p>
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTag[] InstanceTags{ get; set; }

        /// <summary>
        /// <p>Tag description list. By specifying this parameter, you can bind tags to a launch configuration. Each launch configuration supports up to 30 tags.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Related settings of the CVM host name (HostName).<br>Setting the host name for windows instances is unsupported.<br>When adding this attribute, you must pass the CVM host name. Other unspecified fields will be set to default values.<br>The host name (with the suffix added if it exists) is verified against a maximum length of 46 characters.</p>
        /// </summary>
        [JsonProperty("HostNameSettings")]
        public HostNameSettings HostNameSettings{ get; set; }

        /// <summary>
        /// <p>Related settings of CVM instance name (InstanceName).<br>If the user sets this field in the launch configuration, the InstanceName of instances created by the scaling group is set according to this field and transmitted to CVM. If the user does not set this field in the launch configuration, the InstanceName of instances created by the scaling group is set as "as-{{ scaling group AutoScalingGroupName }}" and transmitted to CVM.<br>When adding new this attribute, the instance name of the CVM must be transmitted. Other fields not transmitted will be set as default values.<br>It will verify whether the instance name (plus the suffix if it exists) exceeds the maximum length of 108 characters.</p>
        /// </summary>
        [JsonProperty("InstanceNameSettings")]
        public InstanceNameSettings InstanceNameSettings{ get; set; }

        /// <summary>
        /// <p>Prepaid mode, that is, parameter settings related to monthly/annual subscription. By specifying this parameter, you can specify the purchase duration of annual and monthly subscription instances, whether to enable auto-renewal, and other attributes. If the billing mode of the specified instance is prepaid, this parameter must be passed.</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>Cloud disk type selection policy. Default value: ORIGINAL. Value range:</p><li>ORIGINAL: use the set cloud disk type</li><li>AUTOMATIC: automatically select the currently available cloud disk type</li>
        /// </summary>
        [JsonProperty("DiskTypePolicy")]
        public string DiskTypePolicy{ get; set; }

        /// <summary>
        /// <p>Hyper Computing Cluster ID. You can obtain this parameter by calling the <a href="https://www.tencentcloud.com/document/product/213/83220?from_cn_redirect=1">DescribeHpcClusters</a> API.<br>Note: This field is empty by default.</p>
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// <p>Public network bandwidth-related information settings for IPv6. If the new instance contains an IPv6 address, this parameter can allocate public network bandwidth to the IPv6 address of the new instance. When the Ipv6AddressCount parameter of the scaling group associated with the launch configuration is 0, this parameter will not take effect.</p>
        /// </summary>
        [JsonProperty("IPv6InternetAccessible")]
        public IPv6InternetAccessible IPv6InternetAccessible{ get; set; }

        /// <summary>
        /// <p>Placement Group id. Only one can be specified.</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>Image family name. Either image Id or image family name must be specified, and one and only one must be filled in. This parameter can be obtained through the <a href="https://www.tencentcloud.com/document/product/213/15715?from_cn_redirect=1">DescribeImages</a> API.</p>
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// <p>CDC ID. Obtain this parameter through the <a href="https://www.tencentcloud.com/document/product/1346/73758?from_cn_redirect=1">DescribeDedicatedClusters</a> API.</p>
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// <p>Custom metadata.</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata{ get; set; }

        /// <summary>
        /// <p>Configure the elastic network interface for scale-out instances.</p><p>Input limits: up to 17 items. When configuring this parameter, you must explicitly include and can only include one PRIMARY. AS does not auto-complete the primary ENI. An explicitly empty array is illegal. Spot instances do not support this parameter.</p><p>The VPC and subnet are automatically injected by the scaling group based on the current candidate subnets. If not configured, they are not transmitted to CVM. The SecurityGroupIds parameter in the launch configuration is retained.</p>
        /// </summary>
        [JsonProperty("NetworkInterfaces")]
        public NetworkInterface[] NetworkInterfaces{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "InstanceTypesCheckPolicy", this.InstanceTypesCheckPolicy);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "HostNameSettings.", this.HostNameSettings);
            this.SetParamObj(map, prefix + "InstanceNameSettings.", this.InstanceNameSettings);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "DiskTypePolicy", this.DiskTypePolicy);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamObj(map, prefix + "IPv6InternetAccessible.", this.IPv6InternetAccessible);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamArrayObj(map, prefix + "NetworkInterfaces.", this.NetworkInterfaces);
        }
    }
}

