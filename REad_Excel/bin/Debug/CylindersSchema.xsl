<?xml version="1.0" standalone="yes"?>
<Cylinders>
  <xs:schema id="Cylinders" xmlns="" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
    <xs:element name="Cylinders" msdata:IsDataSet="true" msdata:Locale="en-US">
      <xs:complexType>
        <xs:choice minOccurs="0" maxOccurs="unbounded">
          <xs:element name="TableCylinders">
            <xs:complexType>
              <xs:sequence>
				<xs:element name="Name" type="xs:string" minOccurs="0" />
                <xs:element name="InHomeIdx" type="xs:string" minOccurs="0" />
                <xs:element name="InWorkIdx" type="xs:string" minOccurs="0" />
                <xs:element name="OutHomeIdx" type="xs:string" minOccurs="0" />
                <xs:element name="OutWorkIdx" type="xs:string" minOccurs="0" />
                <xs:element name="Timeout" type="xs:string" minOccurs="0" />
				<xs:element name="ConfigType" type="xs:string" minOccurs="0" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
 </Cylinders>