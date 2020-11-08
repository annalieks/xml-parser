<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

    <xsl:template match="/">
      <html>
        <body>
          <table border="1">
            <tr>
              <th>Автор</th>
              <th>Рік</th>
              <th>Місто</th>
              <th>Розмір</th>
              <th>ISO</th>
              <th>Формат</th>
              <th>Якість</th>
            </tr>
            <xsl:for-each select="Photos/Photo">
              <tr>
                <td>
                  <xsl:value-of select="@Author"/>
                </td>
                <td>
                  <xsl:value-of select="@Year"/>
                </td>
                <td>
                  <xsl:value-of select="@City"/>
                </td>
                <td>
                  <xsl:value-of select="@Size"/>
                </td>
                <td>
                  <xsl:value-of select="@ISO"/>
                </td>
                <td>
                  <xsl:value-of select="@Format"/>
                </td>
                <td>
                  <xsl:value-of select="@Quality"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
